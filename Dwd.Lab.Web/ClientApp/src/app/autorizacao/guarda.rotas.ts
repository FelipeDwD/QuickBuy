import {Injectable} from "@angular/core";
import {Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot} from "@angular/router";


@Injectable({
    //A declaração abaixo diz onde a classe deverá ser publicada
    providedIn: 'root'
})

export class GuardaRotas implements CanActivate{

    constructor(private router: Router) {        

    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        var autenticado = sessionStorage.getItem("usuario-logado");
        if(autenticado == "1"){            
            return true;
        }else{            
           
            this.router.navigate(['/login-usuario'], {queryParams: {returnUrl: state.url}});             
            return false;
        }      

    }
   
}