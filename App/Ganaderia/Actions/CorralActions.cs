using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class CorralActions
    {
        private ConexionContext db;

        public CorralActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<CORRAL>> Obtener()
        {
            List<CORRAL> lista = await this.db.corral
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(CORRAL corral)
        {
            this.db.corral.Add(corral);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges < 0) ? false : true; 
        }

        public async Task<CORRAL> Buscar(int? id)
        {
            var dato = await this.db.corral.FindAsync(id);

            return (dato == null) ? null : dato;
        }

        public async Task<Boolean> Actualizar(int? id, CORRAL corral)
        {
            var entidad = await db.corral.FindAsync(id);

            if (entidad == null)
            {
                entidad = corral;
                int saveChanges = await db.SaveChangesAsync();

                return (saveChanges < 0) ? false : true; 
            }
            else
            {
                return false;
            }
        }

        public async Task<Boolean> Eliminar(int? id)
        {
            var entidad = await db.corral.FindAsync(id);

            if (entidad != null)
            {
                entidad.estado = 0;
                int saveChanges = await db.SaveChangesAsync();
            
                return (saveChanges < 0) ? false : true; 
                
            }
            else
            {
                return false;
            }
        }
    }
}