import { Component, OnInit } from '@angular/core';
import { TarifaService } from './tarifa.service';
import { ResponseTarifa } from '../models/ResponseTarifa';
import { DropdownList } from '../models/DropdownList';
import { Planos } from '../models/Planos';
import { RequestTarifa } from '../models/RequestTarifa';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-tarifa',
  templateUrl: './tarifa.component.html',
  styleUrls: ['./tarifa.component.css']
})
export class TarifaComponent implements OnInit {

    tarifaService: TarifaService;
    requestTarifa: RequestTarifa;
    tarifaForm: FormGroup;

    

    tarifa: ResponseTarifa;

    planos: DropdownList[] = [
        { value: null, viewValue: '' },
        { value: Planos.FaleMais30, viewValue: 'FaleMais 30' },
        { value: Planos.FaleMais60, viewValue: 'FaleMais 60' },
        { value: Planos.FaleMais120, viewValue: 'FaleMais 120' }
    ];


    constructor(_tarifaService: TarifaService) {
        this.requestTarifa = new RequestTarifa();
        this.tarifa = new ResponseTarifa();
        this.tarifaService = _tarifaService;
        this.tarifaForm = new FormGroup({ plano: new FormControl(this.requestTarifa.plano, Validators.required) });
    }

  ngOnInit() {
  }

    getTarifa() {
        this.tarifaService
            .GetTarifas(this.requestTarifa)
            .subscribe(res => {
                this.tarifa = res;
                console.log(this.tarifa);
            });
    }

}
