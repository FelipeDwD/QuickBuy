import { Component, OnInit } from '@angular/core';
import { Usuario } from 'src/app/Models/usuario';

@Component({
  selector: 'app-login-usuario-page',
  templateUrl: './login-usuario-page.component.html',
  styleUrls: ['./login-usuario-page.component.css']
})
export class LoginUsuarioPageComponent implements OnInit {  

  public usuario;
  

  constructor() {
    this.usuario = new Usuario();
   }

  ngOnInit() {
    
  }

  loginUsuario() : void{
    alert(this.usuario.email + " - " + this.usuario.senha);
  }

}
