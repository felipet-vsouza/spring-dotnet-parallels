package br.com.felipetvsouza.document;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDate;

@AllArgsConstructor
@Builder
@Data
@NoArgsConstructor
public class GradeDocument {

    private LocalDate date;

    private String grade;

    private Integer score;

}
