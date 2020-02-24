import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.component.html',
  styleUrls: ['./contato.component.css']
})
export class ContatoComponent implements OnInit {

  cep:string;
  logradouro:string;
  cidade:string;
  uf:string;

  constructor(private http:HttpClient) { }

  ngOnInit() {
  }

  busca() {
    this.http.get<Cep>("http://viacep.com.br/ws/" + this.cep + "/json/").
      subscribe(result => {
        this.logradouro = result.logradouro;
        this.cidade = result.localidade;
        this.uf = result.uf;
      });
  }
  
}

interface Cep {
  cep:string;
  logradouro:string;
  complemento:string;
  bairro:string;
  localidade:string;
  uf:string;
  unidade:string;
  ibge:string;
  gia:string;
  erro:string;
}