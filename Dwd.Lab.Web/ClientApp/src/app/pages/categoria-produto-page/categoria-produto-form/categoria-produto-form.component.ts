import { Component, OnInit } from '@angular/core';
import { CategoriaProduto } from 'src/app/Models/categoria-produto';
import { Router } from '@angular/router';
import { CategoriaProdutoService } from 'src/app/services/categoria-produto/categoria-produto-service';
import { analyzeAndValidateNgModules } from '@angular/compiler';

@Component({
  selector: 'app-categoria-produto-form',
  templateUrl: './categoria-produto-form.component.html',
  styleUrls: ['./categoria-produto-form.component.css']
})
export class CategoriaProdutoFormComponent implements OnInit {

  protected categoriaProduto: CategoriaProduto
  private paginaAnterior: any;

  constructor(private route: Router,
              private categoriaProdutoService: CategoriaProdutoService) { }

  ngOnInit() {
    this.categoriaProduto = new CategoriaProduto();
  }


  cadastrar():void{
    this.categoriaProdutoService.cadastrarCategoria(this.categoriaProduto)
    .subscribe(
      ok => {
        this.route.navigate(['/categoria-produto-main']);
      },
      err => {

      }
    )
  }

  back():void{
    this.paginaAnterior = history.back();
    this.route.navigate([this.paginaAnterior]);

  }

}
