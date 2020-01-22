import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioGridPageComponent } from './usuario-grid-page.component';

describe('UsuarioGridPageComponent', () => {
  let component: UsuarioGridPageComponent;
  let fixture: ComponentFixture<UsuarioGridPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsuarioGridPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsuarioGridPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
