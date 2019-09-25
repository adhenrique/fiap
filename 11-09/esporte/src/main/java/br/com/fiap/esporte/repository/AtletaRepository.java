package br.com.fiap.esporte.repository;

import br.com.fiap.esporte.model.Atleta;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface AtletaRepository extends JpaRepository<Atleta, Integer> {
    List<Atleta> findByNomeContainsIgnoreCase(String nome);
}
