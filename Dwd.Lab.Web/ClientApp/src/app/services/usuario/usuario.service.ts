//Injectable: Permite que a classe atual seja configurada para ser injetada em outro lugar e/ou outra classe.
//Inject: Utilizado para pegar o endereço do site, toda vez que o sistema rodar, o inject vai pegar a url. 
import { Injectable, Inject } from "@angular/core";

//HttpClient: Responsável por fazer requisições web e chamar serviços através da internet.
//HttpHeaders: Junto com as requisições é necessário defirnir um cabeçalho para as mesmas, para isso é utilizado o HttpHeaders.
import { HttpClient, HttpHeaders } from "@angular/common/http";

//Rxjs: Biblioteca para programação reativa do JavaScript, chamadas assíncronas aos serviços do back-end.
import { Observable } from "rxjs";
import { Usuario } from "src/app/Models/usuario";
import { BaseService } from "../base.service";

@Injectable({
    providedIn: "root"
})

export class UsuarioService extends BaseService{

    private baseURL: string;
    public user: Usuario;

    constructor(
        private http: HttpClient) {
            super();
         }

    public get getUser() {
        return this.user;
    }

    private setUser(user: Usuario): void {
        this.user = user;
    }

    public login(user: Usuario): void {
        this.setUser(user);
        sessionStorage.setItem("usuario-logado", "1");
    }

    public logout():void{
        this.setUser(null);
        sessionStorage.setItem("usuario-logado", "0");
    }

    public logado():boolean{
        let isLogado = sessionStorage.getItem("usuario-logado") == "1";
        if(isLogado){
            return true;
        }else{
            return false;
        }
    }    

    public loginUser(usuario: Usuario): Observable<Usuario> {
        const headers = new HttpHeaders().set('content-type', 'application/json');

        var body = {
            email: usuario.email,
            senha: usuario.senha,           
        }

        this.baseURL = `${this.urlApi}/usuario/login`
        return this.http.post<Usuario>(this.baseURL, body, { headers });
    }

    public cadastrarNovoUsuario(usuario: Usuario): Observable<Usuario>{
        const headers = new HttpHeaders().set('content-type', 'application/json');

        let body = {
            nome: usuario.nome,
            sobrenome: usuario.sobrenome,
            cpf: usuario.cpf,
            email: usuario.email,
            senha: usuario.senha
        }

        this.baseURL = `${this.urlApi}/usuario/adicionar`;
        return this.http.post<Usuario>(this.baseURL, body, {headers});
    }

    public retornarTodos():Observable<Usuario>{

        this.baseURL = `${this.urlApi}/usuario`

        return this.http.get<Usuario>(this.baseURL)
    }

}