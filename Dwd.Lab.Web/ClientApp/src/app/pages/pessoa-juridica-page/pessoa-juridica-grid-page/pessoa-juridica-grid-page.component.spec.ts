import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PessoaJuridicaGridPageComponent } from './pessoa-juridica-grid-page.component';

describe('PessoaJuridicaGridPageComponent', () => {
  let component: PessoaJuridicaGridPageComponent;
  let fixture: ComponentFixture<PessoaJuridicaGridPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaJuridicaGridPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaJuridicaGridPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
