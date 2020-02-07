using FaleMais.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FaleMais.Infra.Repository.Interface
{
    public interface ITarifaRepository
    {
        Task<Tarifa> GetTarifas(int origem, int destino);
    }
}
