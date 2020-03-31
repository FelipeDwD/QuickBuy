import { Injectable } from "@angular/core";
import { BaseService } from "../base.service";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Cidade } from "src/app/Models/cidade";

@Injectable({
    providedIn: "root"
})

export class CidadeService extends BaseService {

    constructor(private http: HttpClient){
        super();
    }

    public getSelectListByIdEstado(estadoId:number):Observable<Cidade[]>{
        this.baseURL = `${this.urlApi}/cidade/${estadoId}`
        return this.http.get<Cidade[]>(this.baseURL);
    }
}