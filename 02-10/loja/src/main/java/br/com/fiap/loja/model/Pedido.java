package br.com.fiap.loja.model;

import org.springframework.format.annotation.DateTimeFormat;

import javax.persistence.*;
import javax.validation.constraints.DecimalMin;
import javax.validation.constraints.Future;
import javax.validation.constraints.NotBlank;
import javax.validation.constraints.Size;
import java.time.LocalDate;

@Entity
@SequenceGenerator(name = "pedido", sequenceName = "SQ_T_PEDIDO", allocationSize = 1)
public class Pedido {

    @Id
    @GeneratedValue(generator = "pedido", strategy = GenerationType.SEQUENCE)
    private int codigo;

    @Future
    @DateTimeFormat(pattern = "dd/MM/yyyy")
    private LocalDate dataPedido;

    @NotBlank
    @Size(max = 100, min = 3)
    private String produto;

    @DecimalMin("0")
    private double valor;

    @ManyToOne
    private Cliente cliente;

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public LocalDate getDataPedido() {
        return dataPedido;
    }

    public void setDataPedido(LocalDate dataPedido) {
        this.dataPedido = dataPedido;
    }

    public String getProduto() {
        return produto;
    }

    public void setProduto(String produto) {
        this.produto = produto;
    }

    public double getValor() {
        return valor;
    }

    public void setValor(double valor) {
        this.valor = valor;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }
}
