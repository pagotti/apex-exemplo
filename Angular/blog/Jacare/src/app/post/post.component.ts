import { Component, OnInit, Input } from '@angular/core';
import { Postagem } from '../miniatura/postagem';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  @Input()
  postagem: Postagem = new Postagem();

  constructor(private http:HttpClient) { }

  ngOnInit() {
  }

  like() {
    this.http.post('http://localhost:63096/api/postagens/like/1', null).
      subscribe(() => {
        this.postagem.likes += 1;
      });
  }

  dislike() {
    this.http.post('http://localhost:63096/api/postagens/dislike/1', null).
    subscribe(() => {
      this.postagem.dislikes += 1;
    });
  }

}
