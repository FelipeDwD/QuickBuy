import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoGridPageComponent } from './produto-grid-page.component';

describe('ProdutoGridPageComponent', () => {
  let component: ProdutoGridPageComponent;
  let fixture: ComponentFixture<ProdutoGridPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdutoGridPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdutoGridPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
