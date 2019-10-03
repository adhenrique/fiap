package br.com.fiap.loja.repository;

import br.com.fiap.loja.model.Pedido;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface PedidoRepository extends JpaRepository<Pedido, Integer> {
    List<Pedido> findByCliente_Codigo(int codigo);
}
