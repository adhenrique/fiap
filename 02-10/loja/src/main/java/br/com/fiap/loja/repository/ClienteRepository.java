package br.com.fiap.loja.repository;

import br.com.fiap.loja.model.Cliente;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface ClienteRepository extends JpaRepository<Cliente, Integer> {
    List<Cliente> findByNomeContainsIgnoreCaseOrCpfContains(String nome, String cpf);
}
