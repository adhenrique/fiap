package br.com.fiap.esporte.repository;

import br.com.fiap.esporte.model.Atleta;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AtletaRepository extends JpaRepository<Atleta, Integer> {
}
