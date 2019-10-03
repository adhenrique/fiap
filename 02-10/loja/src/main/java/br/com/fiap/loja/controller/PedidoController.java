package br.com.fiap.loja.controller;

import br.com.fiap.loja.model.Cliente;
import br.com.fiap.loja.model.Pedido;
import br.com.fiap.loja.repository.ClienteRepository;
import br.com.fiap.loja.repository.PedidoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import javax.validation.Valid;
import java.util.List;

@Controller
@RequestMapping("/pedido")
public class PedidoController {
    @Autowired
    private PedidoRepository repository;

    @Autowired
    private ClienteRepository clienteRepository;

    @GetMapping("/listar/{id}")
    public String listar(@PathVariable("id") int codigoCliente, Model model) {
        Cliente cliente = clienteRepository.findById(codigoCliente).get();
        List<Pedido> pedidos = repository.findByCliente_Codigo(codigoCliente);
        model.addAttribute("cliente", cliente);
        model.addAttribute("pedidos", pedidos);

        return "pedido/listar";
    }

    @GetMapping("/cadastrar/{id}")
    public String cadastrar(@PathVariable("id") int codigoCliente, Pedido pedido, Model model) {
        Cliente cliente = clienteRepository.findById(codigoCliente).get();
        pedido.setCliente(cliente);
        model.addAttribute("cliente", cliente);
        return "pedido/form";
    }

    @PostMapping("/salvar")
    public String cadastrar(@Valid Pedido pedido, BindingResult result, RedirectAttributes redirectAttributes, Model model) {
        if (result.hasErrors()) {
            Cliente cliente = clienteRepository.findById(pedido.getCliente().getCodigo()).get();
            pedido.setCliente(cliente);
            model.addAttribute("cliente", cliente);
            return "pedido/form";
        }

        repository.save(pedido);
        redirectAttributes.addFlashAttribute("msg", "Pedido inserido.");
        return "redirect:/pedido/listar/" + pedido.getCliente().getCodigo();
    }
}
