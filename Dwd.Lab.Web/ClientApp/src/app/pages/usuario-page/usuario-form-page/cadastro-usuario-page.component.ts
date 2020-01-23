import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Usuario } from 'src/app/Models/usuario';
import { FormComponent } from 'src/app/shared/form/form.component';

@Component({
  selector: 'app-cadastro-usuario-page',
  templateUrl: './cadastro-usuario-page.component.html',
  styleUrls: ['./cadastro-usuario-page.component.css']
})
export class CadastroUsuarioPageComponent extends FormComponent implements OnInit {

  private paginaAnterior: any;
  protected usuario: any;

  constructor(private router: Router, 
    private usuarioService: UsuarioService) {
      super();
     }

  ngOnInit() {
    this.usuario = new Usuario();
  }  

  back(): void{
    let logado = this.usuarioService.logado();
    this.paginaAnterior = history.back();

    if(logado){
      this.router.navigate([this.paginaAnterior]);
    }else{
      this.router.navigate(['/login-usuario']);
    }
  }

  cadastrarUsuario():void{
    this.ativarSpinner = true;
    this.usuarioService.cadastrarNovoUsuario(this.usuario)
    .subscribe(
      ok => {
      this.router.navigate(['/login-usuario']);
      this.mostraDialogo(`Cadastro efetuado com sucesso`, `success`, 2000);
    },
    err =>{
      this.ativarSpinner = false;
    });
      
    }
  

}
