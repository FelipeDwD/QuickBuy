import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginUsuarioPageComponent } from './login-usuario-page.component';

describe('LoginUsuarioPageComponent', () => {
  let component: LoginUsuarioPageComponent;
  let fixture: ComponentFixture<LoginUsuarioPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoginUsuarioPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginUsuarioPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
