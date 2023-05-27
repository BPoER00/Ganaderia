using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class CorralesActions
    {
        private ConexionContext db;

        public CorralesActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<CORRAL>> obtener()
        {
            var lista = await this.db.corral
                                .Where(x => x.estado == CORRAL.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(CORRAL corral)
        {
            this.db.corral.Add(corral);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}