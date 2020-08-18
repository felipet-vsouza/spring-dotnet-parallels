package br.com.felipetvsouza.response;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

import java.util.List;

@Builder
@Getter
@Setter
@AllArgsConstructor
public class Restaurant {

    private String id;

    private String borough;

    private String cuisine;

    private String name;

    private Address address;

    private List<Grade> grades;

}
