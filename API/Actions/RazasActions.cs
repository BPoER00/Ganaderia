using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class RazasActions
    {
        private ConexionContext db;

        public RazasActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<RAZA>> obtener()
        {
            var lista = await this.db.raza
                                .Where(x => x.estado == RAZA.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> guardar(RAZA raza)
        {
            this.db.raza.Add(raza);
            int saveChanges = await this.db.SaveChangesAsync();

            return (saveChanges != 0) ? true : false;
        }
    }
}