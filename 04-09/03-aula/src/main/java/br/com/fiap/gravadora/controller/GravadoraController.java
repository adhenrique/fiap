package br.com.fiap.gravadora.controller;

import br.com.fiap.gravadora.model.Gravadora;
import br.com.fiap.gravadora.repository.GravadoraRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

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
    public String cadastrar(Gravadora gravadora, RedirectAttributes redirectAttributes){
        // cadastrar ou salvar gravadora no banco
        rep.save(gravadora);

        // enviar mensagem para o front
        redirectAttributes.addFlashAttribute("msg", "Gravadora removida.");

        // retornar a pagina
        return "redirect:/gravadora/listar";
    }

    @GetMapping("editar/{id}")
    public String editar(@PathVariable("id") int codigo, Model model) {
        model.addAttribute("gravadora", rep.findById(codigo));
        return "gravadora/form";
    }

    @PostMapping("excluir")
    public String excluir(Gravadora gravadora, RedirectAttributes redirectAttributes){
        // cadastrar ou salvar gravadora no banco
        rep.delete(gravadora);

        // enviar mensagem para o front
        redirectAttributes.addFlashAttribute("msg", "Gravadora removida.");

        // retornar a pagina
        return "redirect:/gravadora/listar";
    }
}
