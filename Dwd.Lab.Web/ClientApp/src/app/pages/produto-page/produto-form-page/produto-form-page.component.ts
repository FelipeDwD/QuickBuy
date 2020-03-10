import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/app/Models/produto';
import { FormComponent } from 'src/app/shared/form/form.component';
import { Router } from '@angular/router';
import { CategoriaProdutoService } from 'src/app/services/categoria-produto/categoria-produto-service';

@Component({
  selector: 'app-produto-form-page',
  templateUrl: './produto-form-page.component.html',
  styleUrls: ['./produto-form-page.component.css']
})
export class ProdutoFormPageComponent extends FormComponent implements OnInit {

  protected produto: Produto;

  constructor(private route: Router,
              private categoriaProdutoService: CategoriaProdutoService) {                
    super();
  }

  ngOnInit() {  
    this.produto = new Produto();
    this.loadCategoriaProduto();  
  }

  loadCategoriaProduto():void{
    this.categoriaProdutoService.retornarTodos()
    .subscribe(
      items => {
          this.items = items;
      },
      err => {
        this.items = err;
      }
    )
  }

}
