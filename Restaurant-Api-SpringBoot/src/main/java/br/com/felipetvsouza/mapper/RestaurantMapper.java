package br.com.felipetvsouza.mapper;

import br.com.felipetvsouza.document.RestaurantDocument;
import br.com.felipetvsouza.response.Restaurant;
import lombok.RequiredArgsConstructor;
import org.springframework.stereotype.Component;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Component
@RequiredArgsConstructor
public class RestaurantMapper {

    private final AddressMapper addressMapper;

    private final GradeMapper gradeMapper;

    public Restaurant from(RestaurantDocument document) {
        var address = addressMapper.from(document.getAddress());
        var grades = Optional.ofNullable(document.getGrades())
                .map(List::stream)
                .map(stream -> stream.map(gradeMapper::from))
                .map(stream -> stream.collect(Collectors.toList()))
                .orElse(new ArrayList<>());

        return Restaurant.builder()
                .borough(document.getBorough())
                .cuisine(document.getCuisine())
                .name(document.getName())
                .id(document.getId())
                .address(address)
                .grades(grades)
                .build();
    }

    public RestaurantDocument from(Restaurant model) {
        var address = addressMapper.from(model.getAddress());
        var grades = Optional.ofNullable(model.getGrades())
                .map(List::stream)
                .map(stream -> stream.map(gradeMapper::from))
                .map(stream -> stream.collect(Collectors.toList()))
                .orElse(new ArrayList<>());

        return RestaurantDocument.builder()
                .borough(model.getBorough())
                .cuisine(model.getCuisine())
                .name(model.getName())
                .id(model.getId())
                .address(address)
                .grades(grades)
                .build();
    }

}
