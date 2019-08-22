package br.com.fiap.aula02.repository;

import br.com.fiap.aula02.entity.Produto;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProdutoRepository extends JpaRepository<Produto, Integer> {
}
