using FaleMais.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.DTO
{
    public class RequestTarifa
    {
        public int Origem { get; set; }
        public int Destino { get; set; }
        public int Tempo { get; set; }
        public Planos? Plano { get; set; }
    }
}
