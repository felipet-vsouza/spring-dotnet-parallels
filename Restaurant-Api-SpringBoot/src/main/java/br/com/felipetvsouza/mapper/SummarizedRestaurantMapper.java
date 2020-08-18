package br.com.felipetvsouza.mapper;

import br.com.felipetvsouza.document.RestaurantDocument;
import br.com.felipetvsouza.response.SummarizedRestaurant;
import org.springframework.stereotype.Component;

@Component
public class SummarizedRestaurantMapper {

    public SummarizedRestaurant from(RestaurantDocument document) {
        return SummarizedRestaurant.builder()
                .borough(document.getBorough())
                .cuisine(document.getCuisine())
                .id(document.getId())
                .name(document.getName())
                .build();
    }

}
