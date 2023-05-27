using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class FincasActions
    {
        private ConexionContext db;

        public FincasActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<FINCA>> Obtener()
        {
            List<FINCA> lista = await this.db.finca
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(FINCA finca)
        {
            this.db.finca.Add(finca);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges < 0) ? false : true; 
        }

        public async Task<FINCA> Buscar(int? id)
        {
            var dato = await this.db.finca.FindAsync(id);

            return (dato == null) ? null : dato;
        }

        public async Task<Boolean> Actualizar(int? id, FINCA finca)
        {
            var entidad = await db.finca.FindAsync(id);

            if (entidad != null)
            {
                entidad = finca;
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
            var entidad = await db.finca.FindAsync(id);

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