import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoFormPageComponent } from './produto-form-page.component';

describe('ProdutoFormPageComponent', () => {
  let component: ProdutoFormPageComponent;
  let fixture: ComponentFixture<ProdutoFormPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdutoFormPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdutoFormPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
