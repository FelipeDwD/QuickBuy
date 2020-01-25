import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Usuario } from 'src/app/Models/usuario';
import { FormComponent } from 'src/app/shared/form/form.component';
import { ProdutoService } from 'src/app/services/produto/produto.service';

@Component({
  selector: 'app-cadastro-usuario-page',
  templateUrl: './cadastro-usuario-page.component.html',
  styleUrls: ['./cadastro-usuario-page.component.css']
})
export class CadastroUsuarioPageComponent extends FormComponent implements OnInit {

  private paginaAnterior: any;
  protected usuario: any;
  protected produto: any;
  protected arquivoSelecionado: File;

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
      let logado = this.usuarioService.logado();

      this.usuarioService.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        ok => {

        },
        err =>{

        }
      );

      if(logado){
        this.router.navigate(['/usuario-main']);
      }else{
        this.router.navigate(['/login-usuario']);
      }      
    },
    err =>{
      this.ativarSpinner = false;
    });
      
    }

    inputChange(file: FileList):void{
      this.arquivoSelecionado = file[0];      
    }
  

}
