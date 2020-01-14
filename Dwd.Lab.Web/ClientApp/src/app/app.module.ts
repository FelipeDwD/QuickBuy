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
import { LoginUsuarioPageComponent } from './pages/usuario/login-usuario-page/login-usuario-page.component';
import { ProdutoComponent } from './pages/produto-page/produto.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { UsuarioService } from './services/usuario/usuario.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ProdutoComponent,
    LoginUsuarioPageComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent, canActivate: [GuardaRotas] },
      { path: 'fetch-data', component: FetchDataComponent, canActivate: [GuardaRotas] },
      { path: 'produto', component: ProdutoComponent, canActivate: [GuardaRotas] },
      { path: 'login-usuario', component: LoginUsuarioPageComponent}
    ])
  ],
  providers: [UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
