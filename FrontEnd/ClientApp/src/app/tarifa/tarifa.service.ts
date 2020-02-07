import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ResponseTarifa } from 'src/app/models/ResponseTarifa';
import { RequestTarifa } from 'src/app/models/RequestTarifa';

@Injectable({
  providedIn: 'root'
})
export class TarifaService {

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

    public GetTarifas(request:RequestTarifa
    ): Observable<ResponseTarifa> {
        return this.http.get<ResponseTarifa>(this.baseUrl + `api/tarifa?Origem=${request.origem}`
                                                                  + `&Destino=${request.destino}`
                                                                  + `&Tempo=${request.tempo}`
                                                                  + `&Plano=${request.plano}`);
    }
}
