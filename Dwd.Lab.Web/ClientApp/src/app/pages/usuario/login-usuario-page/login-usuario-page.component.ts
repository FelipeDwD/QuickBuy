import { Component, OnInit } from '@angular/core';
import { Usuario } from 'src/app/Models/usuario';
import { Route } from '@angular/compiler/src/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-login-usuario-page',
  templateUrl: './login-usuario-page.component.html',
  styleUrls: ['./login-usuario-page.component.css'],  
})
export class LoginUsuarioPageComponent implements OnInit {  

  public usuario;
  public emailSis = "felipeneves089@gmail.com";
  public senhaSis = "123";
  public logado: boolean = false;
  public routerCall;
  

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {    
   }

  ngOnInit() {
    this.routerCall = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }  

  loginUsuario() : void{     
    if(this.usuario.email == this.emailSis && this.usuario.senha == this.senhaSis ){
        sessionStorage.setItem("usuario-logado", "1");
        this.logado = true;  
        this.router.navigate([this.routerCall]);      
    }
  }

}
