import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { UsuarioService } from './services/usuario/usuario.service';
import { Usuario } from './Models/usuario';
import { FormComponent } from './shared/form/form.component';
import { LoginUsuarioPageComponent } from './pages/usuario-page/login-usuario-page/login-usuario-page.component';
import { CadastroUsuarioPageComponent } from './pages/usuario-page/usuario-form-page/cadastro-usuario-page.component';
import { UsuarioGridPageComponent } from './pages/usuario-page/usuario-grid-page/usuario-grid-page.component';
import { UsuarioMainPageComponent } from './pages/usuario-page/usuario-main-page/usuario-main-page.component';
import { GridComponent } from './shared/grid/grid.component';
import { ProdutoGridPageComponent } from './pages/produto-page/produto-grid-page/produto-grid-page.component';
import { ProdutoFormPageComponent } from './pages/produto-page/produto-form-page/produto-form-page.component';
import { ProdutoMainPageComponent } from './pages/produto-page/produto-main-page/produto-main-page.component';
import { ImagemService } from './services/imagem/imagemUsuario.service';
import { CategoriaProdutoMainComponent } from './pages/categoria-produto-page/categoria-produto-main/categoria-produto-main.component';
import { CategoriaProdutoFormComponent } from './pages/categoria-produto-page/categoria-produto-form/categoria-produto-form.component';
import { CategoriaProdutoGridComponent } from './pages/categoria-produto-page/categoria-produto-grid/categoria-produto-grid.component';
import { PessoaFisicaFormPageComponent } from './pages/pessoa-fisica-page/pessoa-fisica-form-page/pessoa-fisica-form-page.component';
import { PessoaFisicaGridPageComponent } from './pages/pessoa-fisica-page/pessoa-fisica-grid-page/pessoa-fisica-grid-page.component';
import { NgbDatepicker, NgbDatepickerModule, NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PessoaJuridicaFormPageComponent } from './pages/pessoa-juridica-page/pessoa-juridica-form-page/pessoa-juridica-form-page.component';
import { PessoaJuridicaGridPageComponent } from './pages/pessoa-juridica-page/pessoa-juridica-grid-page/pessoa-juridica-grid-page.component';
import { EnderecoFormPageComponent } from './pages/endereco-page/endereco-form-page/endereco-form-page.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,    
    LoginUsuarioPageComponent,
    CadastroUsuarioPageComponent,
    FormComponent,
    UsuarioGridPageComponent,
    UsuarioMainPageComponent,
    GridComponent,
    ProdutoMainPageComponent,
    ProdutoGridPageComponent,
    ProdutoFormPageComponent,    
    CategoriaProdutoMainComponent,
    CategoriaProdutoFormComponent,
    CategoriaProdutoGridComponent,
    PessoaFisicaFormPageComponent,
    PessoaFisicaGridPageComponent,
    PessoaJuridicaFormPageComponent,
    PessoaJuridicaGridPageComponent,    
    EnderecoFormPageComponent,    
    ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgbDatepickerModule,
    NgbModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, canActivate:[GuardaRotas], pathMatch: 'full' },      
      { path: 'produto-main', component: ProdutoMainPageComponent, canActivate: [GuardaRotas] },
      { path: 'produto-form', component: ProdutoFormPageComponent, canActivate: [GuardaRotas]},
      { path: 'produto-grid', component: ProdutoGridPageComponent, canActivate: [GuardaRotas]},
      { path: 'login-usuario', component: LoginUsuarioPageComponent},
      { path: 'usuario-form', component: CadastroUsuarioPageComponent},
      { path: 'usuario-main', component: UsuarioMainPageComponent, canActivate: [GuardaRotas]},
      { path: 'usuario-grid', component: UsuarioGridPageComponent, canActivate: [GuardaRotas]},
      { path: 'categoria-produto-main', component: CategoriaProdutoMainComponent},
      { path: 'categoria-produto-form', component: CategoriaProdutoFormComponent},
      { path: 'categoria-produto-grid', component: CategoriaProdutoGridComponent}, 
      { path: 'pessoa-fisica-form', component: PessoaFisicaFormPageComponent},
      { path: 'pessoa-juridica-form', component: PessoaJuridicaFormPageComponent},
      { path: 'endereco-form', component: EnderecoFormPageComponent}
    ])
  ],
  providers: [UsuarioService,
              ImagemService],
              
  bootstrap: [AppComponent]
})
export class AppModule { }
