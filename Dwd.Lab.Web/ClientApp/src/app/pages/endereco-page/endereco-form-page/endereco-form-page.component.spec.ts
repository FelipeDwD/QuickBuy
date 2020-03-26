import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EnderecoFormPageComponent } from './endereco-form-page.component';

describe('EnderecoFormPageComponent', () => {
  let component: EnderecoFormPageComponent;
  let fixture: ComponentFixture<EnderecoFormPageComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EnderecoFormPageComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EnderecoFormPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
