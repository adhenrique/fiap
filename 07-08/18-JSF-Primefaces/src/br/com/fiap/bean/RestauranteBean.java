package br.com.fiap.bean;

import java.util.Calendar;
import java.util.List;

import javax.annotation.PostConstruct;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.faces.context.FacesContext;
import javax.persistence.EntityManager;

import br.com.fiap.dao.RestauranteDAO;
import br.com.fiap.dao.impl.RestauranteDAOImpl;
import br.com.fiap.entity.Restaurante;
import br.com.fiap.exception.CommitException;
import br.com.fiap.singleton.EntityManagerFactorySingleton;

@ManagedBean
@RequestScoped
public class RestauranteBean {

	private RestauranteDAO dao;
	
	private Restaurante restaurante;
	
	private String nomeBusca;
	
	private List<Restaurante> lista;
	
	public void buscar() {
		setLista(dao.buscarPorNome(nomeBusca));
	}
	
	public List<String> completaNomeRestaurante(String nome) {
		return dao.buscarPorNomeAutocomplete(nome);
	}
	
	@PostConstruct
	public void inicializar() {
		EntityManager em = EntityManagerFactorySingleton.getInstance().createEntityManager();
		dao = new RestauranteDAOImpl(em);
		restaurante = new Restaurante();
		restaurante.setDataAbertura(Calendar.getInstance());
		setLista(dao.listar());
	}
	
	public String cadastrar() {
		try {
			dao.cadastrar(restaurante);
			dao.commit();
			adicionarMensagem("Cadastrado!");
			return "restaurante?faces-redirect=true";
		} catch (CommitException e) {
			e.printStackTrace();
			adicionarMensagem("Erro");
		}
		return "restaurante";
	}
	
	private void adicionarMensagem(String mensagem) {
		FacesMessage msg = new FacesMessage(mensagem);
		FacesContext.getCurrentInstance().addMessage(null, msg);
		FacesContext.getCurrentInstance().getExternalContext().getFlash().setKeepMessages(true);
	}

	public Restaurante getRestaurante() {
		return restaurante;
	}

	public void setRestaurante(Restaurante restaurante) {
		this.restaurante = restaurante;
	}

	public String getNomeBusca() {
		return nomeBusca;
	}

	public void setNomeBusca(String nomeBusca) {
		this.nomeBusca = nomeBusca;
	}

	public List<Restaurante> getLista() {
		return lista;
	}

	public void setLista(List<Restaurante> lista) {
		this.lista = lista;
	}
	
}
