package br.com.felipetvsouza.mapper;

import br.com.felipetvsouza.document.AddressDocument;
import br.com.felipetvsouza.response.Address;
import org.springframework.stereotype.Component;

@Component
public class AddressMapper {

    public Address from(AddressDocument document) {
        return Address.builder()
                .building(document.getBuilding())
                .coord(document.getCoord())
                .street(document.getStreet())
                .zipcode(document.getZipcode())
                .build();
    }

    public AddressDocument from(Address model) {
        return AddressDocument.builder()
                .building(model.getBuilding())
                .coord(model.getCoord())
                .street(model.getStreet())
                .zipcode(model.getZipcode())
                .build();
    }

}
