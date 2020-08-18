package br.com.felipetvsouza.response;

import lombok.Builder;
import lombok.Getter;
import lombok.Setter;

import java.time.LocalDate;

@Builder
@Getter
@Setter
public class Grade {

    private LocalDate date;

    private String grade;

    private Integer score;

}
