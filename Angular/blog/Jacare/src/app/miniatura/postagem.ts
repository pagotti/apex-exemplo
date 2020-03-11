import { Autor } from './autor';

export class Postagem {
    id:number;
    titulo:string;
    data:Date;
    texto:string;
    likes:number;
    dislikes:number;
    foto:string;
    autor:Autor;
}