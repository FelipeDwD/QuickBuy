import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PessoaFisicaGridPageComponent } from './pessoa-fisica-grid-page.component';

describe('PessoaFisicaGridPageComponent', () => {
  let component: PessoaFisicaGridPageComponent;
  let fixture: ComponentFixture<PessoaFisicaGridPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaFisicaGridPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaFisicaGridPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
