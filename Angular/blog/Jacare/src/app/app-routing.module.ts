import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { PostcompletoComponent } from './postcompleto/postcompleto.component';


const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'post', component: PostcompletoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
