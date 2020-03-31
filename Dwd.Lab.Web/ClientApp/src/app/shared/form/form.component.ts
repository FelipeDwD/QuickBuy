import { Component, OnInit } from '@angular/core';
import * as $ from "jquery";

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {

  protected ativarSpinner: boolean;
  protected mensagemValidacao: string = "";     
  protected items: any;
  protected items1: any;
  protected items2: any;

  constructor() { }

  ngOnInit() {
  }

}
