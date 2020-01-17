import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ThrowStmt } from '@angular/compiler';
import { UsuarioService } from '../services/usuario/usuario.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

    //Ao colocar um(vários parâmetros no construtor, o o TypeScript entende como uma declaração do tipo na classe, e automaticamente faz a instância do tipo).
    constructor(private router: Router, private usuarioServico: UsuarioService) {      

    }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  usuarioLogado():boolean{
    return this.usuarioServico.getUser() != null;   
  }

  sairUsuario():void{
    this.usuarioServico.setUser(null);
  }
}
