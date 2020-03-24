import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PessoaFisicaFormPageComponent } from './pessoa-fisica-form-page.component';

describe('PessoaFisicaFormPageComponent', () => {
  let component: PessoaFisicaFormPageComponent;
  let fixture: ComponentFixture<PessoaFisicaFormPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaFisicaFormPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaFisicaFormPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
