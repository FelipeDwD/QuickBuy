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
  
  protected sexoMasculino: boolean;
  protected isEdit: boolean;
 

  constructor(private router: Router,
    private usuarioService: UsuarioService,
    private imagemService: ImagemService) {
    super();
  }

  ngOnInit() {
    let usuarioSession = sessionStorage.getItem('user');

    if(usuarioSession){
      this.usuario = JSON.parse(usuarioSession);   
      this.isEdit = true; 
      if(this.usuario.sexo == "M"){
        this.sexoMasculino = true;
      }
    }else{
      this.usuario = new Usuario();
      this.isEdit = false;    
    }   
  }

  back(): void {
    let logado = this.usuarioService.logado();
    this.paginaAnterior = history.back();
    
    if (logado) {
      this.router.navigate([this.paginaAnterior]);
    } else {
      this.router.navigate(['/login-usuario']);
    }
  }

  save(): void {
    this.ativarSpinner = true;  
    this.verificarSexo();    

    if(this.arquivoSelecionado != null){
      this.cadastroImagem();
    }else{
      this.cadastrarSimples();
    }    
    this.ativarSpinner = false;
   
  }

  inputChange(file: FileList): void {
    this.arquivoSelecionado = file[0];
  }
  

  cadastroImagem(): void {
    this.imagemService.enviarArquivo(this.arquivoSelecionado)
      .subscribe(
        image => {
          this.usuario.imagem = image;
          this.cadastrarSimples();
        });
  }

  cadastrarSimples(): void {
    if(this.isEdit){
      this.usuarioService.put(this.usuario)
      .subscribe(
        ok => {
          this.redirect();
        },
        err => {
          this.mensagemValidacao = err.error;
        }
      )
    }else{
      this.usuarioService.post(this.usuario)
      .subscribe(
        ok => {
          this.redirect();
        },
        err => {
          this.mensagemValidacao = err.error;
        });
    }    
  }

  redirect():void{
    let logado = this.usuarioService.logado();

          if (logado) {
            this.router.navigate(['/usuario-main']);
          } else {
            this.router.navigate(['/login-usuario']);
          }
  }

  verificarSexo():void{
    let sexo = document.getElementsByName('checkSexo') as any as HTMLInputElement;

    if(sexo[0].checked){
        this.usuario.sexo = 'M';
        this.usuario.imagem = 'defaultM.png'        
    }else if(sexo[1].checked){
      this.usuario.sexo = 'F';      
      this.usuario.imagem = 'defaultF.png'
    }
  }  
}
