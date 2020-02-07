using FaleMais.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.Models
{
    public class Tarifa
    {
        public int Origem { get; set; }
        public int Destino { get; set; }
        public double PrecoMinuto { get; set; }

        public ResponseTarifa ToDTO(RequestTarifa requestTarifa)
        {
            return new ResponseTarifa()
            {
                Origem = this.Origem,
                Destino = this.Destino,
                PrecoMinuto = this.PrecoMinuto,
                Tempo = requestTarifa.Tempo,
                Plano = requestTarifa.Plano
            };
        }
    }
}
