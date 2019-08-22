package br.com.fiap.aula01.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class HomeController {

    @GetMapping("inicio") // url
    public String index() {
        return "home"; // pagina
    }
}
