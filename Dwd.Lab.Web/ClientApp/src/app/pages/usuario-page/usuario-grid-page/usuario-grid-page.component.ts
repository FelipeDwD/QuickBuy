import { Component, OnInit } from '@angular/core';
import { GridComponent } from 'src/app/shared/grid/grid.component';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { Usuario } from 'src/app/Models/usuario';

@Component({
  selector: 'app-usuario-grid-page',
  templateUrl: './usuario-grid-page.component.html',
  styleUrls: ['./usuario-grid-page.component.css']
})
export class UsuarioGridPageComponent extends GridComponent implements OnInit {

  constructor(private usuarioService: UsuarioService) {
    super();
   }

  ngOnInit() {
    this.loadUsers();
  }

  loadUsers():void{
    this.usuarioService.retornarTodos()
    .subscribe(
      item =>{
      this.items = item;
    },
    err =>{

    });         
  }

  deleteUser(user: Usuario):void{
    this.usuarioService.deletar(user)
    .subscribe()
      location.reload(true);
  }

}
