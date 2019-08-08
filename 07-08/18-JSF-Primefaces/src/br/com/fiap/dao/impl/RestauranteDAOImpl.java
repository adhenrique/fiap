package br.com.fiap.dao.impl;

import br.com.fiap.entity.Restaurante;

import java.util.List;

import javax.persistence.EntityManager;

import br.com.fiap.dao.RestauranteDAO;

public class RestauranteDAOImpl extends GenericDAOImpl<Restaurante, Integer> implements RestauranteDAO{

	public RestauranteDAOImpl(EntityManager em) {
		super(em);
	}

	@Override
	public List<String> buscarPorNomeAutocomplete(String nome) {
		return em.createQuery("select r.nome from Restaurante r where r.nome like :n",String.class)
				.setParameter("n", "%" +nome + "%").getResultList();
	}

	@Override
	public List<Restaurante> buscarPorNome(String nome) {
		return em.createQuery("from Restaurante r where r.nome like :n",Restaurante.class)
				.setParameter("n", "%" +nome + "%").getResultList();
	}

}
