package br.com.fiap.aula01.controller;

import br.com.fiap.aula01.model.Restaurante;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("restaurante")
public class RestauranteController {

    @GetMapping("/")
    public String index() {
        return "restaurante/index";
    }

    @GetMapping("cadastro")
    public String cadastro() {
        return "restaurante/cadastrar";
    }

    @PostMapping("cadastro")
    public String cadastro(Restaurante restaurante, Model model) {
        System.out.println("nome: " + restaurante.getNome());
        System.out.println("-----");
        System.out.println("faturamento: " + restaurante.getFaturamento());
        System.out.println("-----");
        System.out.println("endereço: " + restaurante.getEndereco());

        model.addAttribute("msg", "Cadastrado!");
        model.addAttribute("restaurante", restaurante);
        return "restaurante/index";
    }
}
