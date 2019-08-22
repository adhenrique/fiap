package br.com.fiap.aula02.controller;

import br.com.fiap.aula02.entity.Produto;
import br.com.fiap.aula02.repository.ProdutoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("produto")
public class ProdutoController {
    @Autowired
    private ProdutoRepository repository;

    @GetMapping("cadastro")
    public String cadastro(Model model) {
        model.addAttribute("usuarios", repository.findAll());
        return "produto/cadastro";
    }

    @PostMapping("cadastro")
    public String cadastro(Produto produto, Model model) {
        repository.save(produto);
        model.addAttribute("msg", "Cadastrado :D");
        model.addAttribute("usuarios", repository.findAll());
        return "produto/cadastro";
    }
}
