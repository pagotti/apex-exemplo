import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ficha',
  templateUrl: './ficha.component.html',
  styleUrls: ['./ficha.component.css']
})
export class FichaComponent implements OnInit {

  nome:string;
  curso:string;
  data:Date;
  instrutor:string;
  sala:string;
  pontualidade:string;
  conteudo:string;
  instrutornota:string;
  dificuldade:string;
  sugestao:string;
  http:HttpClient;
  baseUrl: string;
  enviou: boolean = false;

  constructor(http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  ngOnInit() {
  }

  enviar() {
    let ficha: Ficha = new Ficha();
    ficha.nome = this.nome;
    ficha.curso = this.curso;
    ficha.data = this.data;
    ficha.instrutor = this.instrutor;
    ficha.salaequipamentonota = parseInt(this.sala);
    ficha.conteudonota = parseInt(this.conteudo);
    ficha.pontualidadenota = parseInt(this.pontualidade);
    ficha.instrutornota = parseInt(this.instrutornota);
    ficha.dificuldade = this.dificuldade;
    ficha.sugestao = this.sugestao;
    this.enviou = true;

    this.http.post(this.baseUrl + "api/fichas", ficha).
      subscribe(r => {
        console.log(r);
        alert("Obrigado por enviar a sua avaliação");
        this.enviou = false;
        this.pagina = 1;
        this.nome = "";
        this.curso = "";
        this.instrutor = "";
        this.data = null;
        this.dificuldade = "";
        this.instrutornota = null;
        this.pontualidade = null;
        this.conteudo = null;
        this.sala = null;
        this.sugestao = "";

      });


  }

  pagina = 1;

  mostra(numero) {
    this.pagina = numero;
  }

  volta() {
    if (this.pagina > 1) {
      this.pagina--;
    }
  }

  vai() {
    if (this.pagina < 3) {
      this.pagina++;
    }
  }

}


class Ficha {
  id: number;
  nome: string;
  curso: string;
  data: Date;
  instrutor: string;
  salaequipamentonota: number;
  pontualidadenota: number;
  conteudonota: number;
  instrutornota: number;
  dificuldade: string;
  sugestao: string;
}
