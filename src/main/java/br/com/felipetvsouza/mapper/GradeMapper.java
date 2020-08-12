package br.com.felipetvsouza.mapper;

import br.com.felipetvsouza.document.GradeDocument;
import br.com.felipetvsouza.response.Grade;
import org.springframework.stereotype.Component;

@Component
public class GradeMapper {

    public Grade from(GradeDocument document) {
        return Grade.builder()
                .date(document.getDate())
                .grade(document.getGrade())
                .score(document.getScore())
                .build();
    }

    public GradeDocument from(Grade model) {
        return GradeDocument.builder()
                .date(model.getDate())
                .grade(model.getGrade())
                .score(model.getScore())
                .build();
    }

}
