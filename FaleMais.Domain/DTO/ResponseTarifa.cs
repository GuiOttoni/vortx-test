using FaleMais.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.DTO
{
    public class ResponseTarifa : Models.Tarifa
    {
        public int Tempo { get; set; }
        public Planos? Plano { get; set; }
        public double ComFaleMais { get; set; }
        public double SemFaleMais { get; set; }
    }
}
