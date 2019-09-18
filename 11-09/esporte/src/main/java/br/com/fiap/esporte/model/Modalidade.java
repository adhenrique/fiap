package br.com.fiap.esporte.model;

import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import java.time.LocalDate;
import java.util.List;

@Entity
@SequenceGenerator(name = "mod", sequenceName = "SQ_T_MODALIDADE", allocationSize = 1)
public class Modalidade {
    @Id
    @GeneratedValue(generator = "mod", strategy = GenerationType.SEQUENCE)
    private int codigo;

    private String nome;

    private boolean individual;

    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private LocalDate data;

    @OneToMany(mappedBy = "modalidade", cascade = CascadeType.ALL)
    private List<Atleta> atletas;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public boolean isIndividual() {
        return individual;
    }

    public void setIndividual(boolean individual) {
        this.individual = individual;
    }

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }

    public List<Atleta> getAtletas() {
        return atletas;
    }

    public void setAtletas(List<Atleta> atletas) {
        this.atletas = atletas;
    }
}
