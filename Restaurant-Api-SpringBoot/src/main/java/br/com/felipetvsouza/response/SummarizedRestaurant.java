package br.com.felipetvsouza.response;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

@Builder
@Getter
@Setter
@AllArgsConstructor
public class SummarizedRestaurant {

    private String id;

    private String borough;

    private String cuisine;

    private String name;

}
