package br.com.felipetvsouza.data;

import br.com.felipetvsouza.document.RestaurantDocument;
import org.springframework.data.mongodb.repository.ReactiveMongoRepository;
import reactor.core.publisher.Flux;

public interface RestaurantRepository extends ReactiveMongoRepository<RestaurantDocument, String> {

    Flux<RestaurantDocument> findByNameStartsWith(String name);

}
