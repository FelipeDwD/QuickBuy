import { Injectable } from "@angular/core";
import { BaseService } from "../base.service";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";



@Injectable({
    providedIn: "root"
})

export class ImagemService extends BaseService{
    private baseURL: string;

    
    constructor(private http: HttpClient) {
        super();            
    }

    public enviarArquivo(arquivoSelecionado: File):Observable<string>{
        const formData: FormData = new FormData();
        formData.append("arquivoEnviado", arquivoSelecionado, arquivoSelecionado.name);
        this.baseURL = `${this.urlApi}/imagem`;
        return this.http.post<string>(this.baseURL, formData);
    }   

}