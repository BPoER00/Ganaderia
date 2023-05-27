using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class GenerosActions
    {
        private ConexionContext db;

        public GenerosActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<GENERO>> Obtener()
        {
            List<GENERO> lista = await this.db.genero
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(GENERO genero)
        {
            this.db.genero.Add(genero);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges > 0) ? false : true; 
        }

        public async Task<GENERO> Buscar(int? id)
        {
            var dato = await this.db.genero.FindAsync(id);

return (dato == null) ? null : dato;        }

        public async Task<Boolean> Actualizar(int? id, GENERO genero)
        {
            var entidad = await db.genero.FindAsync(id);

            if (entidad != null)
            {
                entidad = genero;
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
            var entidad = await db.genero.FindAsync(id);

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