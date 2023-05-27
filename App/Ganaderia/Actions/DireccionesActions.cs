using Ganaderia.Models;
using Microsoft.EntityFrameworkCore;

namespace Ganaderia.Actions
{
    public class DireccionesActions
    {
        private ConexionContext db;

        public DireccionesActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<DIRECCION>> Obtener()
        {
            List<DIRECCION> lista = await this.db.direccion
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(DIRECCION direccion)
        {
            this.db.direccion.Add(direccion);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges > 0) ? true : false; 
        }

        public async Task<DIRECCION> Buscar(int? id)
        {
            var dato = await this.db.direccion.FindAsync(id);

            return (dato != null) ? dato : null;
        }

        public async Task<Boolean> Actualizar(int? id, DIRECCION direccion)
        {
            var entidad = await db.direccion.FindAsync(id);

            if (entidad != null)
            {
                entidad = direccion;
                int saveChanges = await db.SaveChangesAsync();

                return (saveChanges > 0) ? true : false; 
            }
            else
            {
                return false;
            }
        }

        public async Task<Boolean> Eliminar(int? id)
        {
            var entidad = await db.direccion.FindAsync(id);

            if (entidad != null)
            {
                entidad.estado = 0;
                int saveChanges = await db.SaveChangesAsync();
            
                return (saveChanges > 0) ? true : false; 
            }
            else
            {
                return false;
            }
        }
    }
}