import { Component, OnInit } from '@angular/core';
import { Usuario } from 'src/app/Models/usuario';
import { Route } from '@angular/compiler/src/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { error } from 'util';

@Component({
  selector: 'app-login-usuario-page',
  templateUrl: './login-usuario-page.component.html',
  styleUrls: ['./login-usuario-page.component.css'],
})
export class LoginUsuarioPageComponent implements OnInit {

  public usuario;
  public returnUrl: string;
  public mensagem: string;


  constructor(
    private router: Router,
    private activatedRouter: ActivatedRoute,
    private usuarioService: UsuarioService) {
  }

  ngOnInit() {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  loginUsuario(): void {

    this.usuarioService.verificarUsuario(this.usuario)
      .subscribe(
        data => {
          //Essa linha será executada no caso de retorno sem erro.       
          this.usuarioService.login(this.usuario);

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
        }
      );
  }
}



