import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriaProdutoFormComponent } from './categoria-produto-form.component';

describe('CategoriaProdutoFormComponent', () => {
  let component: CategoriaProdutoFormComponent;
  let fixture: ComponentFixture<CategoriaProdutoFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategoriaProdutoFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoriaProdutoFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
