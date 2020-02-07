import { Planos } from "./Planos";

export class ResponseTarifa {
    origem: number;
    destino: number;
    precoMinuto: number;
    tempo: number;
    plano: Planos;
    comFaleMais: number;
    somFaleMais: number;
}
