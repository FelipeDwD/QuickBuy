import { Component, OnInit } from '@angular/core';
import { GridComponent } from 'src/app/shared/grid/grid.component';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { Usuario } from 'src/app/Models/usuario';
import { ImagemService } from 'src/app/services/imagem/imagemUsuario.service';

@Component({
  selector: 'app-usuario-grid-page',
  templateUrl: './usuario-grid-page.component.html',
  styleUrls: ['./usuario-grid-page.component.css']
})
export class UsuarioGridPageComponent extends GridComponent implements OnInit {

  constructor(private usuarioService: UsuarioService,
    private imagemService: ImagemService) {
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

  editar(user: Usuario):void{
    console.log(user.nome)
  }

  alterarStatus(usuario: Usuario):void{  
    this.ativarSpinner = true;
    this.usuarioService.alterarStatus(usuario)
    .subscribe( 
      a => {
        this.loadUsers();
        this.ativarSpinner = false;
      }
    );      
    //location.reload();
  }

  //Método desabilitado em: 2020-02-01
  // deleteUser(user: Usuario):void{
  //   this.usuarioService.deletar(user)
  //   .subscribe()
  //     this.imagemService.excluirArquivo(user.imagem)
  //     .subscribe();
  //     location.reload(true);      
  // }
}
