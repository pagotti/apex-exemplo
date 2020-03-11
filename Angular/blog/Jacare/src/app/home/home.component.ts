import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Postagem } from '../miniatura/postagem';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  postagens: Postagem[];

  constructor(private http:HttpClient) {
     
    http.get<Postagem[]>('http://localhost:63096/api/postagens').
      subscribe(resultado => {
        this.postagens = resultado;
      });
  }

  ngOnInit() {
  }

}
