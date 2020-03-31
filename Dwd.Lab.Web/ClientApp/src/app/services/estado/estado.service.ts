import { Injectable } from "@angular/core";
import { BaseService } from "../base.service";
import { Observable } from "rxjs";
import { Estado } from "src/app/Models/estado";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: "root"
})

export class EstadoService extends BaseService{
    

    constructor(private http: HttpClient){
        super();
    }

    public getSelectList(): Observable<Estado[]>{
        this.baseURL = `${this.urlApi}/estado`;
        return this.http.get<Estado[]>(this.baseURL);
    }
}