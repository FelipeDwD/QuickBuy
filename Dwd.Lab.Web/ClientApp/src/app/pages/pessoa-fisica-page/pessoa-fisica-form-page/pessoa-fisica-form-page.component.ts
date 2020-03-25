import { Component, OnInit } from '@angular/core';
import {NgbDateStruct, NgbCalendar, NgbDateParserFormatter, NgbDateAdapter} from '@ng-bootstrap/ng-bootstrap';
import { CustomAdapter, CustomDateParserFormatter } from 'src/app/shared/Date/date.format';

@Component({
  selector: 'app-pessoa-fisica-form-page',
  templateUrl: './pessoa-fisica-form-page.component.html',
  styleUrls: ['./pessoa-fisica-form-page.component.css'],
  providers: [
    {provide: NgbDateAdapter, useClass: CustomAdapter},
    {provide: NgbDateParserFormatter, useClass: CustomDateParserFormatter}
  ]
 
})
export class PessoaFisicaFormPageComponent implements OnInit {
   
 
  ngOnInit() {
  }

  constructor(private ngbCalendar: NgbCalendar, private dateAdapter: NgbDateAdapter<string>) {
    
  }   

  onlynumber(evt) {
    var theEvent = evt || window.event;
    var key = theEvent.keyCode || theEvent.which;
    key = String.fromCharCode( key );
    //var regex = /^[0-9.,]+$/;
    var regex = /^[0-9.]+$/;
    if( !regex.test(key) ) {
       theEvent.returnValue = false;
       if(theEvent.preventDefault) theEvent.preventDefault();
    }
 }
}
