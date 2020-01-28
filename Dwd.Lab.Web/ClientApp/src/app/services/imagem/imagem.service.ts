import { Injectable } from "@angular/core";
import { BaseService } from "../base.service";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { ImagemUsuario } from "src/app/Models/imagemUsuario";


@Injectable({
    providedIn: "root"
})

export class ImagemService extends BaseService{
    private baseURL: string;

    
    constructor(private http: HttpClient) {
        super();            
    }

    public enviarArquivo(arquivoSelecionado: File):Observable<ImagemUsuario>{
        const formData: FormData = new FormData();
        formData.append("arquivoEnviado", arquivoSelecionado, arquivoSelecionado.name);
        this.baseURL = `${this.urlApi}/imagemusuario/enviararquivo`;
        return this.http.post<ImagemUsuario>(this.baseURL, formData);
    }

    public salvarImagem(imagemUsuario: ImagemUsuario): Observable<ImagemUsuario>{
        const headers = new HttpHeaders().set('content-type', 'application/json');

        let body = {
            nome: imagemUsuario.nome
        }

        this.baseURL = `${this.urlApi}/imagemusuario`;
        return this.http.post<ImagemUsuario>(this.baseURL, body, {headers});
    }




}