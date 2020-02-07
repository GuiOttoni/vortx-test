using FaleMais.Domain.DTO;
using FaleMais.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FaleMais.Infra.Service.Interface
{
    public interface ITarifaService
    {
        Task<ResponseTarifa> GetTarifas(RequestTarifa requestTarifa);
    }
}
