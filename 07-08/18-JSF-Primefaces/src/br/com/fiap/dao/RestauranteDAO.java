package br.com.fiap.dao;

import java.util.List;

import br.com.fiap.entity.Restaurante;

public interface RestauranteDAO extends GenericDAO<Restaurante, Integer>{

	List<String> buscarPorNomeAutocomplete(String nome);
	
	List<Restaurante> buscarPorNome(String nome);
	
}
