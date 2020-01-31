import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ThrowStmt } from '@angular/compiler';
import { UsuarioService } from '../services/usuario/usuario.service';
import { Usuario } from '../Models/usuario';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
  
  

    public usuario: Usuario;

    //Ao colocar um(vários parâmetros no construtor, o o TypeScript entende como uma declaração do tipo na classe, e automaticamente faz a instância do tipo).
    constructor(private router: Router, 
      private usuarioService: UsuarioService) {     
      
    }

    ngOnInit(): void {
      
    }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  usuarioLogado(): boolean{
    let logado = this.usuarioService.logado();
    if(logado){      
      return true;
    }else{
      return false;
    }
  }

  logout():void{
    this.usuarioService.logout();
  }

 

  

}