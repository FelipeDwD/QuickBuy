import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-usuario-main-page',
  templateUrl: './usuario-main-page.component.html',
  styleUrls: ['./usuario-main-page.component.css']
})
export class UsuarioMainPageComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  novo():void{
    this.router.navigate(['/usuario-form']);
  }

}
