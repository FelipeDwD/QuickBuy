import {Injectable} from "@angular/core";
import {Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot} from "@angular/router";
import { UsuarioService } from "../services/usuario/usuario.service";
import { fakeAsync } from "@angular/core/testing";

@Injectable({
    providedIn: "root"
})

export class GuardaRotas implements CanActivate{

    constructor(private router: Router, private userService: UsuarioService) {        
        
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        let logado = this.userService.logado();
        if(logado){            
            return true;
        }else{           
            this.router.navigate(['/login-usuario'], {queryParams: {returnUrl: state.url}});             
            return false;
        }  
    }
   
}