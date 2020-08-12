package br.com.felipetvsouza.controller;

import br.com.felipetvsouza.response.Restaurant;
import br.com.felipetvsouza.response.SummarizedRestaurant;
import br.com.felipetvsouza.service.RestaurantService;
import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.*;
import reactor.core.publisher.Flux;
import reactor.core.publisher.Mono;

@RequestMapping("/api/restaurant")
@RestController
@RequiredArgsConstructor
public class RestaurantController {

    private final RestaurantService service;

    @GetMapping("/{id}")
    public Mono<Restaurant> getRestaurant(@PathVariable("id") String id) {
        return service.findById(id);
    }

    @GetMapping
    public Flux<SummarizedRestaurant> listRestaurants(@RequestParam(value = "name", required = false) String name) {
        return service.listByName(name);
    }

    @PostMapping
    public Mono<Restaurant> saveRestaurant(@RequestBody Restaurant restaurant) {
        return service.save(restaurant);
    }

    @PutMapping
    public Mono<Restaurant> updateRestaurant(@RequestBody Restaurant restaurant) {
        return service.save(restaurant);
    }

    @DeleteMapping
    public Mono<Void> deleteRestaurant(@RequestBody Restaurant restaurant) {
        return service.delete(restaurant);
    }

}
