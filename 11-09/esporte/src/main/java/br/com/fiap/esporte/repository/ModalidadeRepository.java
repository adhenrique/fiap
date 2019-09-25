package br.com.fiap.esporte.repository;

import br.com.fiap.esporte.model.Modalidade;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface ModalidadeRepository extends JpaRepository<Modalidade, Integer> {
    List<Modalidade> findByNomeContainsIgnoreCase(String nome);
}
