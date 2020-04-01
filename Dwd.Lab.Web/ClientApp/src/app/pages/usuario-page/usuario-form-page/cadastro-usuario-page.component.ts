import { Component, OnInit } from '@angular/core';
import { UsuarioService } from 'src/app/services/usuario/usuario.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Usuario } from 'src/app/Models/usuario';
import { FormComponent } from 'src/app/shared/form/form.component';
import { ProdutoService } from 'src/app/services/produto/produto.service';
import { ImagemService } from 'src/app/services/imagem/imagemUsuario.service';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';



@Component({
  selector: 'app-cadastro-usuario-page',
  templateUrl: './cadastro-usuario-page.component.html',
  styleUrls: ['./cadastro-usuario-page.component.css']
})
export class CadastroUsuarioPageComponent extends FormComponent implements OnInit {

  private paginaAnterior: any;
  protected usuario: Usuario;
  protected arquivoSelecionado: File;
  protected emailConfirmado: string;
  protected senhaEspelho : any;
  
  
 
 

  constructor(private router: Router,
    private usuarioService: UsuarioService,
    private imagemService: ImagemService) {
    super();
  }

  ngOnInit() {
       this.usuario = new Usuario();
       this.senhaEspelho = ''
  }

  

  
}
