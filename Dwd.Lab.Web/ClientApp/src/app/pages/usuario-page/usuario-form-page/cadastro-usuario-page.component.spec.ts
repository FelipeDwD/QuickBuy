import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroUsuarioPageComponent } from './cadastro-usuario-page.component';



function mostraDialogo(mensagem, tipo, tempo){
    
  // se houver outro alert desse sendo exibido, cancela essa requisição
  if($("#message").is(":visible")){
      return false;
  }

  // se não setar o tempo, o padrão é 3 segundos
  if(!tempo){
      let tempo = 3000;
  }

  // se não setar o tipo, o padrão é alert-info
  if(!tipo){
      let tipo = "info";
  }

  // monta o css da mensagem para que fique flutuando na frente de todos elementos da página
  var cssMessage = "display: block; position: fixed; top: 0; left: 20%; right: 20%; width: 60%; padding-top: 10px; z-index: 9999";
  var cssInner = "margin: 0 auto; box-shadow: 1px 1px 5px black;";

  // monta o html da mensagem com Bootstrap
  var dialogo = "";
  dialogo += '<div id="message" style="'+cssMessage+'">';
  dialogo += '    <div class="alert alert-'+tipo+' alert-dismissable" style="'+cssInner+'">';
  dialogo += '    <a href="#" class="close" data-dismiss="alert" aria-label="close">×</a>';
  dialogo +=          mensagem;
  dialogo += '    </div>';
  dialogo += '</div>';

  // adiciona ao body a mensagem com o efeito de fade
  $("body").append(dialogo);
  $("#message").hide();
  $("#message").fadeIn(200);

  // contador de tempo para a mensagem sumir
  setTimeout(function() {
      $('#message').fadeOut(300, function(){
          $(this).remove();
      });
  }, tempo); // milliseconds

}

describe('CadastroUsuarioPageComponent', () => {
  let component: CadastroUsuarioPageComponent;
  let fixture: ComponentFixture<CadastroUsuarioPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastroUsuarioPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroUsuarioPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
