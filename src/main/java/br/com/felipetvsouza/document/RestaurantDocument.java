package br.com.felipetvsouza.document;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;
import org.springframework.data.mongodb.core.mapping.Document;
import org.springframework.data.annotation.Id;

import java.util.List;

@AllArgsConstructor
@Builder
@Data
@Document(collection = "restaurants")
@NoArgsConstructor
public class RestaurantDocument {

    @Id
    private String id;

    private String borough;

    private String cuisine;

    private String name;

    private AddressDocument address;

    private List<GradeDocument> grades;

}
