import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PessoaJuridicaFormPageComponent } from './pessoa-juridica-form-page.component';

describe('PessoaJuridicaFormPageComponent', () => {
  let component: PessoaJuridicaFormPageComponent;
  let fixture: ComponentFixture<PessoaJuridicaFormPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaJuridicaFormPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaJuridicaFormPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
