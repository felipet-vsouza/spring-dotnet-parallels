package br.com.felipetvsouza.document;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@AllArgsConstructor
@Builder
@Data
@NoArgsConstructor
public class AddressDocument {

    private String building;

    private String street;

    private String zipcode;

    private List<Double> coord;

}
