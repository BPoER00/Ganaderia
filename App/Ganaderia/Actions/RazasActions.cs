using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class RazasActions
    {
        private ConexionContext db;

        public RazasActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<RAZA>> Obtener()
        {
            List<RAZA> lista = await this.db.raza
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(RAZA raza)
        {
            this.db.raza.Add(raza);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges > 0) ? false : true; 
        }

        public async Task<RAZA> Buscar(int? id)
        {
            var dato = await this.db.raza.FindAsync(id);

return (dato == null) ? null : dato;        }

        public async Task<Boolean> Actualizar(int? id, RAZA raza)
        {
            var entidad = await db.raza.FindAsync(id);

            if (entidad != null)
            {
                entidad = raza;
                int saveChanges = await db.SaveChangesAsync();

                return (saveChanges > 0) ? false : true; 
            }
            else
            {
                return false;
            }
        }

        public async Task<Boolean> Eliminar(int? id)
        {
            var entidad = await db.raza.FindAsync(id);

            if (entidad != null)
            {
                entidad.estado = 0;
                int saveChanges = await db.SaveChangesAsync();
            
                return (saveChanges > 0) ? false : true; 
                
            }
            else
            {
                return false;
            }
        }
    }
}