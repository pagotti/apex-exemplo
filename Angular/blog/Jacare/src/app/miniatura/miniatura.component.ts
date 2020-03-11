import { Component, OnInit, Input } from '@angular/core';
import { Postagem } from './postagem';

@Component({
  selector: 'app-miniatura',
  templateUrl: './miniatura.component.html',
  styleUrls: ['./miniatura.component.css']
})
export class MiniaturaComponent implements OnInit {

  @Input()
  postagem: Postagem = new Postagem();

  constructor() { }

  ngOnInit() {
  }

}
