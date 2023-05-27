using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class RangoDePesosActions
    {
        private ConexionContext db;

        public RangoDePesosActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<RANGO_DE_PESO>> obtener()
        {
            var lista = await this.db.rango_de_peso
                                .Where(x => x.estado == RANGO_DE_PESO.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(RANGO_DE_PESO rango_de_peso)
        {
            this.db.rango_de_peso.Add(rango_de_peso);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}