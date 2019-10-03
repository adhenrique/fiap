package br.com.fiap.loja.controller;

import br.com.fiap.loja.model.Cliente;
import br.com.fiap.loja.repository.ClienteRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import javax.validation.Valid;
import java.util.List;

@Controller
@RequestMapping("/cliente")
public class ClienteController {

    @Autowired
    private ClienteRepository repository;

    @GetMapping("listar")
    public String listar(Model model) {
        return "cliente/listar";
    }

    @GetMapping("buscar")
    public String buscar(String termoBusca, Model model) {
        List<Cliente> clientes = repository.findByNomeContainsIgnoreCaseOrCpfContains(termoBusca, termoBusca);
        model.addAttribute("clientes", clientes);
        model.addAttribute("termoBusca", termoBusca);
        return "cliente/listar";
    }

    @GetMapping("cadastrar")
    public String cadastrar(Cliente cliente, Model model) {
        return "cliente/form";
    }

    @PostMapping("salvar")
    public String salvar(@Valid Cliente cliente, BindingResult result, RedirectAttributes redirectAttributes) {
        if (result.hasErrors()) {
            return "cliente/form";
        }

        String message = "Cliente salvo";
        repository.save(cliente);

        redirectAttributes.addFlashAttribute("msg", message);

        return "redirect:/cliente/cadastrar";
    }
}
