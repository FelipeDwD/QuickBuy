import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriaProdutoGridComponent } from './categoria-produto-grid.component';

describe('CategoriaProdutoGridComponent', () => {
  let component: CategoriaProdutoGridComponent;
  let fixture: ComponentFixture<CategoriaProdutoGridComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CategoriaProdutoGridComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoriaProdutoGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
