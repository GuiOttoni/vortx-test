using FaleMais.Infra.Repository.Interface;
using FaleMais.Infra.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FaleMais.Domain.Enums;
using FaleMais.Domain.DTO;
using System.Threading.Tasks;
using FaleMais.Domain.Models;
using FaleMais.Domain.IMPL;

namespace FaleMais.Infra.Service
{
    public class TarifaService : ITarifaService
    {
        private ITarifaRepository tarifaRepository;

        public TarifaService(ITarifaRepository _tarifaRepository)
        {
            tarifaRepository = _tarifaRepository;
        }

        public async Task<ResponseTarifa> GetTarifas(RequestTarifa requestTarifa)
        {
            try
            {
                Tarifa tarifa = await tarifaRepository.GetTarifas(requestTarifa.Origem, requestTarifa.Destino);

                if (tarifa == null)
                    return new ResponseTarifa() {   Destino = requestTarifa.Destino, 
                                                    Origem = requestTarifa.Origem, 
                                                    Plano = requestTarifa.Plano,
                                                    Tempo = requestTarifa.Tempo};

                ResponseTarifa response = tarifa.ToDTO(requestTarifa);

                response.SemFaleMais = CalculadoraTarifa.CalculoSemPlano(response);
                response.ComFaleMais = CalculadoraTarifa.CalculoComPlano(response);

                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
