import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MiniaturaComponent } from './miniatura/miniatura.component';
import { HomeComponent } from './home/home.component';
import { PostcompletoComponent } from './postcompleto/postcompleto.component';
import { PostComponent } from './post/post.component';
import { ComentarioComponent } from './comentario/comentario.component';

@NgModule({
  declarations: [
    AppComponent,
    MiniaturaComponent,
    HomeComponent,
    PostcompletoComponent,
    PostComponent,
    ComentarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
