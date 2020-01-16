//Injectable: Permite que a classe atual seja configurada para ser injetada em outro lugar e/ou outra classe.
//Inject: Utilizado para pegar o endereço do site, toda vez que o sistema rodar, o inject vai pegar a url. 
import {Injectable, Inject} from "@angular/core";

//HttpClient: Responsável por fazer requisições web e chamar serviços através da internet.
//HttpHeaders: Junto com as requisições é necessário defirnir um cabeçalho para as mesmas, para isso é utilizado o HttpHeaders.
import {HttpClient, HttpHeaders} from "@angular/common/http";

//Rxjs: Biblioteca para programação reativa do JavaScript, chamadas assíncronas aos serviços do back-end.
import {Observable} from "rxjs";
import { Usuario } from "src/app/Models/usuario";

@Injectable({
    providedIn: "root"
})

export class UsuarioService{

    private baseURL: string;

    constructor(
        private http: HttpClient) {}

    public verificarUsuario(usuario: Usuario): Observable<Usuario>{
        const headers = new HttpHeaders().set('content-type', 'application/json');

        var body = {
            email: usuario.email,
            senha: usuario.senha,
            nome: "Felipe",
            sobrenome: "Neves"
        }

        this.baseURL = "https://localhost:44396/api/usuario/verificarUsuario"
        return this.http.post<Usuario>(this.baseURL, body, {headers});
    }

}