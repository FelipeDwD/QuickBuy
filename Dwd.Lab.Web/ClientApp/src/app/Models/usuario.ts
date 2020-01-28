import { ImagemUsuario } from "./imagemUsuario";

export class Usuario {
    id: number;
    nome: string;
    sobrenome: string;
    cpf: string;
    email: string;
    senha: string;
    imagemUsuario: ImagemUsuario;
}