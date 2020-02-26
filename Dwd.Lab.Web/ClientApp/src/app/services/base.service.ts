import { HttpHeaders } from "@angular/common/http";


export class BaseService{
    protected baseURL: string;
    protected urlApi: string = "https://localhost:44396/api"

    //Cabeçalho e corpo HTML.
    protected headers = new HttpHeaders().set('content-type', 'application/json');
    protected body: any;
    
}