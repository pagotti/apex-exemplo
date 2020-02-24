import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ficha';
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
