import { Component, OnInit, Input } from '@angular/core';
import { Usuario } from 'src/app/Models/usuario';
import { Route } from '@angular/compiler/src/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { error } from 'util';
import { FormComponent } from 'src/app/shared/form/form.component';
import { NavMenuComponent } from 'src/app/nav-menu/nav-menu.component';

@Component({
  selector: 'app-login-usuario-page',
  templateUrl: './login-usuario-page.component.html',
  styleUrls: ['./login-usuario-page.component.css'],
})
export class LoginUsuarioPageComponent extends FormComponent implements OnInit {

  public usuario;
  public returnUrl: string;
  public mensagem: string;
  

 

  constructor(
    private router: Router,
    private activatedRouter: ActivatedRoute,
    private usuarioService: UsuarioService) {
      super();
  }

  ngOnInit() {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  loginUsuario(): void {

    this.ativarSpinner = true;   

    this.usuarioService.loginUser(this.usuario)
      .subscribe(
        user => {
          //Essa linha será executada no caso de retorno sem erro.              
          this.usuarioService.login(user);         
          
          if (this.returnUrl == undefined) {
            //Caso o usuário ir direto pelo login (para logar)
            //Se credenciais corretas: ele será redirecionado para o home
            this.router.navigate(['/']);
          } else {
            this.router.navigate([this.returnUrl]);
          }

        },
        err => {
          this.mensagem = err.error;   
          this.ativarSpinner = false;       
        }
      );
      
  }

  cadastroUsuario():void{
    this.router.navigate(['/usuario-form']);
  }
}



