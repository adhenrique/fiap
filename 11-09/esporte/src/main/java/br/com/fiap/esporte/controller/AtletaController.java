package br.com.fiap.esporte.controller;

import br.com.fiap.esporte.model.Atleta;
import br.com.fiap.esporte.repository.AtletaRepository;
import br.com.fiap.esporte.repository.ModalidadeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.util.Optional;

@Controller
@RequestMapping("atletas")
public class AtletaController {

    @Autowired
    private AtletaRepository rep;

    @Autowired
    private ModalidadeRepository modalidadeRepository;

    @GetMapping("listar")
    public String listar(Model model) {
        model.addAttribute("searchAction", "atletas");
        model.addAttribute("atletas", rep.findAll());
        model.addAttribute("modalidades", modalidadeRepository.findAll());
        return "atletas/listar";
    }

    @GetMapping("criar")
    public String criar(Atleta atleta, Model model) {
        model.addAttribute("searchAction", "atletas");
        model.addAttribute("modalidades", modalidadeRepository.findAll());
        return "atletas/form";
    }

    @GetMapping("editar/{id}")
    public String editar(@PathVariable("id") int codigo, Model model) {
        model.addAttribute("atleta", rep.findById(codigo));
        model.addAttribute("modalidades", modalidadeRepository.findAll());
        return "atletas/form";
    }

    // salvar
    @PostMapping("salvar")
    public String salvar(Atleta atleta, RedirectAttributes redirectAttributes) {
        rep.save(atleta);
        String message = "Atleta salvo";

        if (atleta.getCodigo() > 0) {
            message = "Atleta atualizado";
        }
        redirectAttributes.addFlashAttribute("msg", message);

        return "redirect:/atletas/listar";
    }

    // deletar
    @PostMapping("excluir")
    public String excluir(int codigo, RedirectAttributes redirectAttributes) {
        rep.deleteById(codigo);
        redirectAttributes.addAttribute("msg", "Atleta removido");
        return "redirect:/atletas/listar";
    }

    // pesquisar
    @GetMapping("pesquisar/nome")
    public String pesquisar(String nomeBusca, Model model) {
        model.addAttribute("atletas", rep.findByNomeContainsIgnoreCase(nomeBusca));
        model.addAttribute("nomeBusca", nomeBusca);
        model.addAttribute("searchAction", "atletas");
        return "atletas/listar";
    }

    // pesquisar
    @GetMapping("pesquisar/modalidade")
    public String pesquisarPorModalidade(int codigoModalidade, Model model) {
        model.addAttribute("atletas", rep.findByModalidade_Codigo(codigoModalidade));
        model.addAttribute("modalidades", modalidadeRepository.findAll());
        model.addAttribute("codigoModalidade", codigoModalidade);
        model.addAttribute("searchAction", "atletas");
        return "atletas/listar";
    }
}
