using FaleMais.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaleMais.Domain.IMPL
{
    public static class CalculadoraTarifa
    {
        public static double CalculoSemPlano(ResponseTarifa response)
        {
            return response.PrecoMinuto * response.Tempo;
        }

        public static double CalculoComPlano(ResponseTarifa response)
        {
            if (response.Plano == Enums.Planos.FaleMais30 && response.Tempo > 30)
                return CalcPlano(response.Tempo, 30, response.PrecoMinuto);
            if (response.Plano == Enums.Planos.FaleMais60 && response.Tempo > 60)
                return CalcPlano(response.Tempo, 60, response.PrecoMinuto);
            if (response.Plano == Enums.Planos.FaleMais120 && response.Tempo > 120)
                return CalcPlano(response.Tempo, 120, response.PrecoMinuto);
            return 0;
        }

        private static double CalcPlano(int tempo, int plano, double preco) => ((tempo - plano) * preco) * 1.1;
    }
}
