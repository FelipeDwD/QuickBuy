import {Injectable} from "@angular/core";
import {Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot} from "@angular/router";
import { UsuarioService } from "../services/usuario/usuario.service";


export class GuardaRotas implements CanActivate{

    constructor(private router: Router, private usuarioServico: UsuarioService) {        
        
    }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
        if(this.usuarioServico.userLogado()){            
            return true;
        }else{           
            this.router.navigate(['/login-usuario'], {queryParams: {returnUrl: state.url}});             
            return false;
        }      

    }
   
}