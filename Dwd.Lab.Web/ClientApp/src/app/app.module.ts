import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProdutoComponent } from './pages/produto-page/produto.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { UsuarioService } from './services/usuario/usuario.service';
import { Usuario } from './Models/usuario';
import { FormComponent } from './shared/form/form.component';
import { LoginUsuarioPageComponent } from './pages/usuario-page/login-usuario-page/login-usuario-page.component';
import { CadastroUsuarioPageComponent } from './pages/usuario-page/usuario-form-page/cadastro-usuario-page.component';
import { UsuarioGridPageComponent } from './pages/usuario-page/usuario-grid-page/usuario-grid-page.component';
import { UsuarioMainPageComponent } from './pages/usuario-page/usuario-main-page/usuario-main-page.component';
import { GridComponent } from './shared/grid/grid.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProdutoComponent,
    LoginUsuarioPageComponent,
    CadastroUsuarioPageComponent,
    FormComponent,
    UsuarioGridPageComponent,
    UsuarioMainPageComponent,
    GridComponent,   
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, canActivate:[GuardaRotas], pathMatch: 'full' },
      { path: 'counter', component: CounterComponent, canActivate: [GuardaRotas] },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [GuardaRotas] },
      { path: 'produto', component: ProdutoComponent, canActivate: [GuardaRotas] },
      { path: 'login-usuario', component: LoginUsuarioPageComponent},
      { path: 'usuario-form', component: CadastroUsuarioPageComponent},
      { path: 'usuario-main', component: UsuarioMainPageComponent, canActivate: [GuardaRotas]},
      { path: 'usuario-grid', component: UsuarioGridPageComponent, canActivate: [GuardaRotas]}
    ])
  ],
  providers: [UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
