import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
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
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, canActivate:[GuardaRotas], pathMatch: 'full' },      
      { path: 'produto-main', component: ProdutoMainPageComponent, canActivate: [GuardaRotas] },
      { path: 'produto-form', component: ProdutoFormPageComponent, canActivate: [GuardaRotas]},
      { path: 'produto-grid', component: ProdutoGridPageComponent, canActivate: [GuardaRotas]},
      { path: 'login-usuario', component: LoginUsuarioPageComponent},
      { path: 'usuario-form', component: CadastroUsuarioPageComponent},
      { path: 'usuario-main', component: UsuarioMainPageComponent, canActivate: [GuardaRotas]},
      { path: 'usuario-grid', component: UsuarioGridPageComponent, canActivate: [GuardaRotas]}
    ])
  ],
  providers: [UsuarioService,
              ImagemService],
              
  bootstrap: [AppComponent]
})
export class AppModule { }
