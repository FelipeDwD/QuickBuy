import { Component, OnInit } from '@angular/core';
import {NgbDateStruct, NgbCalendar} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-pessoa-fisica-form-page',
  templateUrl: './pessoa-fisica-form-page.component.html',
  styleUrls: ['./pessoa-fisica-form-page.component.css']
})
export class PessoaFisicaFormPageComponent implements OnInit {

  model: NgbDateStruct;
  date: {year: number, month: number};

  ngOnInit() {
  }

  constructor(private calendar: NgbCalendar) {
    
  }  

}
