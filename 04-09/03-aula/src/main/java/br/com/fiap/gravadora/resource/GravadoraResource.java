package br.com.fiap.gravadora.resource;

import br.com.fiap.gravadora.model.Gravadora;
import br.com.fiap.gravadora.repository.GravadoraRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("gravadora")
public class GravadoraResource {

    @Autowired
    private GravadoraRepository rep;

    //URL - http://localhost:8080/gravadora/internacional/false
    @GetMapping("internacional/{inter}")
    public List<Gravadora> pesquisar(@PathVariable boolean inter){
        return rep.findByInternacional(inter);
    }

    //URL - http://localhost:8080/gravadora/buscar?nome=ZZZ&faturamento=10
    @GetMapping("buscar")
    public List<Gravadora> pesquisar(@RequestParam String nome,
                                     @RequestParam(required = false) Double faturamento){
        if (faturamento != null)
            return rep.findByNomeContainsAndFaturamentoIsGreaterThan(nome,faturamento);
        return rep.findByNomeContains(nome);
    }

    @PutMapping("{id}")
    public Gravadora alterar(@PathVariable int id, @RequestBody Gravadora gravadora){
        gravadora.setCodigo(id);
        return rep.save(gravadora);
    }

    @DeleteMapping("{id}")
    public void remover(@PathVariable int id){
        rep.deleteById(id);
    }

    @GetMapping("{id}")
    public Gravadora buscar(@PathVariable int id){
        return rep.findById(id).get();
    }

    @GetMapping
    public List<Gravadora> listar(){
        return rep.findAll();
    }

    @PostMapping
    @ResponseStatus(HttpStatus.CREATED)
    public Gravadora cadastrar(@RequestBody Gravadora gravadora){
        return rep.save(gravadora);
    }

}
