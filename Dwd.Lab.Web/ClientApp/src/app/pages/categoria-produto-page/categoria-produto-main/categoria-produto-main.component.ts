import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categoria-produto-main',
  templateUrl: './categoria-produto-main.component.html',
  styleUrls: ['./categoria-produto-main.component.css']
})
export class CategoriaProdutoMainComponent implements OnInit {

  constructor(private route: Router) { }

  ngOnInit() {
  }


 navigate():void{
   this.route.navigate(['/categoria-produto-form']);
 }

}
