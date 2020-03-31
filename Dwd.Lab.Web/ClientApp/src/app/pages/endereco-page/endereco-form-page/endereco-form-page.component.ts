import { Component, OnInit } from '@angular/core';
import { EstadoService } from 'src/app/services/estado/estado.service';
import { FormComponent } from 'src/app/shared/form/form.component';
import { CidadeService } from 'src/app/services/cidade/cidade.service';


@Component({
  selector: 'app-endereco-form-page',
  templateUrl: './endereco-form-page.component.html',
  styleUrls: ['./endereco-form-page.component.css']
})
export class EnderecoFormPageComponent extends FormComponent implements OnInit {

  constructor(private estadoService: EstadoService,
              private cidadeService: CidadeService) {
    super();
  }

  ngOnInit(): void {
    //Load Estados
    this.getSelectAllEstados();
  }

  getSelectAllEstados() : void{
    this.estadoService.getSelectList()
    .subscribe(
      item => {
        this.items = item;
      },
      err => {
        this.items = err;
      });    
    }

    getSelectListByIdEstado(estadoId: number):void{
      this.cidadeService.getSelectListByIdEstado(estadoId)
      .subscribe(
        item => {
          this.items1 = item;
        },
        err =>
        this.items1 = err
      )
    }
}
