package br.com.fiap.gravadora.controller;

import br.com.fiap.gravadora.model.Gravadora;
import br.com.fiap.gravadora.repository.GravadoraRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
@RequestMapping("gravadora")
public class GravadoraController {
    @Autowired
    private GravadoraRepository rep;

    @GetMapping("listar")
    public String listar(Model model){
        model.addAttribute("gravadoras", rep.findAll());
        return "gravadora/listar";
    }

    @GetMapping("cadastrar")
    public String cadastrar(Gravadora gravadora){
        return "gravadora/form";
    }

    @PostMapping("cadastrar")
    public String cadastrar(Gravadora gravadora, Model model){
        // cadastrar ou salvar gravadora no banco
        rep.save(gravadora);

        // enviar mensagem para o front
        model.addAttribute("msg", "Gravadora salva com sucesso!");

        // retornar a pagina
        return "home";
    }
}
