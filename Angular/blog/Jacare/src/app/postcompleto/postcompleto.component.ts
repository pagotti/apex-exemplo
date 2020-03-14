import { Component, OnInit } from '@angular/core';
import { Postagem } from '../miniatura/postagem';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-postcompleto',
  templateUrl: './postcompleto.component.html',
  styleUrls: ['./postcompleto.component.css']
})
export class PostcompletoComponent implements OnInit {

  postcompleto: Postagem = new Postagem();

  constructor(private http:HttpClient) {
     
    http.get<Postagem>('http://localhost:63096/api/postagens/1').
      subscribe(resultado => {
        this.postcompleto = resultado;
      });
  }

  ngOnInit() {
  }

}
