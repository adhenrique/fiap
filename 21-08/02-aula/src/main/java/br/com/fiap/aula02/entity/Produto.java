package br.com.fiap.aula02.entity;

import javax.persistence.*;

@Entity
@Table(name="TB_PRODUTO")
@SequenceGenerator(name = "produto", sequenceName = "SQ_PRODUTO", allocationSize = 1)
public class Produto {

    @Id
    @Column(name = "cd_produto")
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "produto")
    private int codigo;

    @Column(name = "nm_produto")
    private String nome;

    @Column(name = "vl_produto")
    private double preco;

    @Column(name = "ds_produto")
    private String descricao;

    public Produto() {
    }

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

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }
}
