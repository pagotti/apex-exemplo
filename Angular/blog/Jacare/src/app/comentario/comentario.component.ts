import { Component, OnInit, Input } from '@angular/core';
import { Comentario } from './comentario';

@Component({
  selector: 'app-comentario',
  templateUrl: './comentario.component.html',
  styleUrls: ['./comentario.component.css']
})
export class ComentarioComponent implements OnInit {

  @Input()
  comentario: Comentario = new Comentario();

  constructor() { }

  ngOnInit() {
  }

}
