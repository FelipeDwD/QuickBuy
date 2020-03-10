import { Injectable } from "@angular/core";
import { BaseService } from "../base.service";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { CategoriaProduto } from "src/app/Models/categoria-produto";


@Injectable({
    providedIn: "root"
})

export class CategoriaProdutoService extends BaseService{

   constructor(private http: HttpClient ){
       super();
   }

   buildBody(categoriaProduto: CategoriaProduto):void{
        this.body = {
            id: categoriaProduto.id,
            nome: categoriaProduto.nome,
            descricao: categoriaProduto.descricao
        }
   }

   public cadastrarCategoria(categoriaProduto: CategoriaProduto): Observable<CategoriaProduto>{
       this.buildBody(categoriaProduto);
       this.baseURL = `${this.urlApi}/categoriaProduto`
       return this.http.post<CategoriaProduto>(this.baseURL, this.body, {headers: this.headers});
   }

   public retornarTodos():Observable<CategoriaProduto[]>{
       this.baseURL = `${this.urlApi}/categoriaProduto`
       return this.http.get<CategoriaProduto[]>(this.baseURL, {headers: this.headers});
   }


}