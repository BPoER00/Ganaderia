using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class DireccionesActions
    {
        private ConexionContext db;

        public DireccionesActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<DIRECCION>> obtener()
        {
            var lista = await this.db.direccion
                                .Where(x => x.estado == DIRECCION.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(DIRECCION direccion)
        {
            this.db.direccion.Add(direccion);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}