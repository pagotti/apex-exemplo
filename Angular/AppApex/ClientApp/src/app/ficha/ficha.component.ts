import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ficha',
  templateUrl: './ficha.component.html',
  styleUrls: ['./ficha.component.css']
})
export class FichaComponent implements OnInit {

  nome: string;
  curso: string;
  data: Date;
  instrutor: string;
  sala: number;
  pontualidade: number;
  conteudo: number;
  instrutornota: number;
  dificuldade: string;
  sugestao: string;
  http: HttpClient;
  baseUrl: string;

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
    ficha.salaequipamentonota = this.sala;
    ficha.conteudonota = this.conteudo;
    ficha.pontualidadenota = this.pontualidade;
    ficha.instrutornota = this.instrutornota;
    ficha.dificuldade = this.dificuldade;
    ficha.sugestao = this.sugestao;

    this.http.post(this.baseUrl + "api/fichas", ficha);

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
