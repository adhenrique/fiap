package br.com.fiap.esporte.resource;

import br.com.fiap.esporte.model.Atleta;
import br.com.fiap.esporte.repository.AtletaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/atleta")
public class AtletaResource {
    @Autowired
    private AtletaRepository rep;

    // salvar
    @PostMapping("lesionar")
    public void lesionar(int codigo, boolean lesionado) {
        Atleta atleta = rep.findById(codigo).get();

        atleta.setLesionado(lesionado);
        rep.save(atleta);
    }
}
