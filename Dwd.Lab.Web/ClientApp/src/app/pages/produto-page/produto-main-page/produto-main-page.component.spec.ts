import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProdutoMainPageComponent } from './produto-main-page.component';

describe('ProdutoMainPageComponent', () => {
  let component: ProdutoMainPageComponent;
  let fixture: ComponentFixture<ProdutoMainPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProdutoMainPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProdutoMainPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
