using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Actions
{
    public class FincasActions
    {
        private ConexionContext db;

        public FincasActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<FINCA>> obtener()
        {
            var lista = await this.db.fincas
                                .Where(x => x.estado == FINCA.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(FINCA finca)
        {
            this.db.fincas.Add(finca);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}