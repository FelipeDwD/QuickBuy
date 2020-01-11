import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ThrowStmt } from '@angular/compiler';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

    //Ao colocar um(vários parâmetros no construtor, o o TypeScript entende como uma declaração do tipo na classe).
    constructor(private router: Router) {      

    }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  usuarioLogado():boolean{
    return sessionStorage.getItem("usuario-logado") == "1";   
  }

  sairUsuario():void{
    sessionStorage.setItem("usuario-logado", "0");
    this.router.navigate[''];
  }
}
