import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-livros',
  templateUrl: './livros.component.html'
})
export class LivrosComponent {
 
  public livros: Livro[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Livro[]>(baseUrl + 'api/livros').subscribe(result => {
      this.livros = result;
    }, error => console.error(error));
  }
}

interface Livro {
  titulo: string;
  autor: string;
  edicao: string;
  preco: number;
}
