package br.com.felipetvsouza;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.data.mongodb.repository.config.EnableReactiveMongoRepositories;

@EnableReactiveMongoRepositories
@SpringBootApplication
public class RestaurantAPIApplication {

    public static void main(String[] args) {
        SpringApplication.run(RestaurantAPIApplication.class, args);
    }

}
