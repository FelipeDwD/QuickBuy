import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioMainPageComponent } from './usuario-main-page.component';

describe('UsuarioMainPageComponent', () => {
  let component: UsuarioMainPageComponent;
  let fixture: ComponentFixture<UsuarioMainPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsuarioMainPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioMainPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
