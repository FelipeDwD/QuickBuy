import { BaseService } from "../base.service";
import { Observable } from "rxjs";
import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Produto } from "src/app/Models/produto";

@Injectable({
    providedIn: "root"
})

export class ProdutoService extends BaseService{

    private baseURL: string;
    public produto: ProdutoService;

    constructor(
        private http: HttpClient){
            super();
        }

    public cadastrarNovoProduto(produto: Produto): Observable<Produto>{
        const headers = new HttpHeaders().set('content-type', 'application/json');

        let body = {
            nome: produto.nome,
            descricao: produto.descricao,
            preco: produto.preco
        }

        this.baseURL = `${this.urlApi}/produto`

        return this.http.post<Produto>(this.baseURL, body, {headers})

    }
    
}