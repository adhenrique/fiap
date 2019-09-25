package br.com.fiap.esporte.controller;

import br.com.fiap.esporte.model.Modalidade;
import br.com.fiap.esporte.repository.ModalidadeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

@Controller
@RequestMapping("modalidades")
public class ModalidadeController {

    @Autowired
    private ModalidadeRepository rep;

    @GetMapping("listar")
    public String listar(Model model) {
        model.addAttribute("searchAction", "modalidades");
        model.addAttribute("modalidades", rep.findAll());
        return "modalidades/listar";
    }

    @GetMapping("criar")
    public String criar(Modalidade modalidade, Model model) {
        model.addAttribute("searchAction", "modalidades");
        return "modalidades/form";
    }

    @GetMapping("editar/{id}")
    public String editar(@PathVariable("id") int codigo, Model model) {
        model.addAttribute("modalidade", rep.findById(codigo));
        return "modalidades/form";
    }

    // salvar
    @PostMapping("salvar")
    public String salvar(Modalidade modalidade, RedirectAttributes redirectAttributes) {
        rep.save(modalidade);
        String message = "Modalidade salva";

        if (modalidade.getCodigo() > 0) {
            message = "Modalidade atualizada";
        }
        redirectAttributes.addFlashAttribute("msg", message);

        return "redirect:/modalidades/listar";
    }

    // deletar
    @PostMapping("excluir")
    public String excluir(int codigo, RedirectAttributes redirectAttributes) {
        rep.deleteById(codigo);
        redirectAttributes.addAttribute("msg", "Modalidade removida");
        return "redirect:/modalidades/listar";
    }

    // pesquisar
    @GetMapping("pesquisar")
    public String pesquisar(String nomeBusca, Model model) {
        model.addAttribute("modalidades", rep.findByNomeContainsIgnoreCase(nomeBusca));
        model.addAttribute("nomeBusca", nomeBusca);
        model.addAttribute("searchAction", "atletas");
        return "modalidades/listar";
    }

    // pesquisar
    @GetMapping("detalhes/{id}")
    public String detalhes(@PathVariable("id") int codigo, Model model) {
        model.addAttribute("modalidade", rep.findById(codigo).get());
        model.addAttribute("searchAction", "modalidades");
        return "modalidades/detalhes";
    }
}
