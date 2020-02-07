using FaleMais.Domain.Models;
using FaleMais.Infra.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaleMais.Infra.Repository
{
    public class TarifaRepository : BaseRepository, ITarifaRepository
    {
        public TarifaRepository(Context context) : base(context)
        {
        }

        public async Task<Tarifa> GetTarifas(int origem, int destino)
        {
            return await db.Tarifa.Where(x => x.Origem == origem && x.Destino == destino).FirstOrDefaultAsync();
        }
    }
}
