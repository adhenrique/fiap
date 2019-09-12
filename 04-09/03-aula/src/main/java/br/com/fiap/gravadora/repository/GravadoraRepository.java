package br.com.fiap.gravadora.repository;

import br.com.fiap.gravadora.model.Gravadora;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface GravadoraRepository
                        extends JpaRepository<Gravadora,Integer> {

    //Pesquisar as gravadoras por nome
    List<Gravadora> findByNomeContains(String nome);

    List<Gravadora> findByNomeContainsIgnoreCase(String nome);

    //Pesquisar por gravadoras pelo atributo internacional
    List<Gravadora> findByInternacional(boolean internacional);

    //Pesquisar por parte do nome e faturamento maior que
    List<Gravadora> findByNomeContainsAndFaturamentoIsGreaterThan(String nome, double f);

}
