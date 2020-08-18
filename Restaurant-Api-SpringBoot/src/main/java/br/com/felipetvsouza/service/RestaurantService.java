package br.com.felipetvsouza.service;

import br.com.felipetvsouza.data.RestaurantRepository;
import br.com.felipetvsouza.mapper.RestaurantMapper;
import br.com.felipetvsouza.mapper.SummarizedRestaurantMapper;
import br.com.felipetvsouza.response.Restaurant;
import br.com.felipetvsouza.response.SummarizedRestaurant;
import lombok.RequiredArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;
import reactor.core.publisher.Flux;
import reactor.core.publisher.Mono;

import java.util.Optional;

@RequiredArgsConstructor
@Service
@Slf4j
public class RestaurantService {

    private final RestaurantRepository repository;

    private final RestaurantMapper mapper;

    private final SummarizedRestaurantMapper summarizedRestaurantMapper;

    public Mono<Restaurant> findById(String id) {
        return repository.findById(id)
                .map(mapper::from)
                .doOnError(error -> log.error("There was an error finding by id", error));
    }

    public Flux<SummarizedRestaurant> listByName(String nameParam) {
        return Optional.ofNullable(nameParam)
                .map(repository::findByNameStartsWith)
                .orElseGet(repository::findAll)
                .map(summarizedRestaurantMapper::from)
                .doOnError(error -> log.error("There was an error listing by name", error));
    }

    public Mono<Restaurant> save(Restaurant restaurant) {
        return Mono.just(mapper.from(restaurant))
                .flatMap(repository::save)
                .map(mapper::from)
                .doOnError(error -> log.error("There was an error saving/updating", error));
    }

    public Mono<Void> delete(Restaurant restaurant) {
        return Mono.just(mapper.from(restaurant))
                .flatMap(repository::delete)
                .doOnError(error -> log.error("There was an error deleting", error));
    }

}
