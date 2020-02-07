using System;
using System.Collections.Generic;
using System.Text;
using FaleMais.Infra.Repository;

namespace FaleMais.Infra.Repository
{
    public class BaseRepository
    {
        protected Context db;

        public BaseRepository(Context context)
        {
            db = context;
        }
    }
}
