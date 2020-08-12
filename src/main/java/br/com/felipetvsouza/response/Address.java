package br.com.felipetvsouza.response;

import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

import java.util.List;

@Builder
@Getter
@Setter
public class Address {

    private String building;

    private String street;

    private String zipcode;

    private List<Double> coord;

}
