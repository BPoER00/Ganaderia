using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class GenerosController
    {
        private ConexionContext db;

        public GenerosController(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<GENERO>> obtener()
        {
            var lista = await this.db.genero
                                .Where(x => x.estado == GENERO.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(GENERO genero)
        {
            this.db.genero.Add(genero);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}