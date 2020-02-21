import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-produto-main-page',
  templateUrl: './produto-main-page.component.html',
  styleUrls: ['./produto-main-page.component.css']
})
export class ProdutoMainPageComponent implements OnInit {

   

  constructor(private router: Router) { }

  ngOnInit() {
  }


  navegarParaFormulario():void{
    this.router.navigate(['/produto-form']);
  }
 


}
