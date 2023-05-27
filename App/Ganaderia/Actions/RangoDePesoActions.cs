using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class RangoDePesoActions
    {
        private ConexionContext db;

        public RangoDePesoActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<RANGO_DE_PESO>> Obtener()
        {
            List<RANGO_DE_PESO> lista = await this.db.rango_de_peso
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();
            
            return lista;
        }

        public async Task<Boolean> Guardar(RANGO_DE_PESO rango_de_peso)
        {
            this.db.rango_de_peso.Add(rango_de_peso);
            int saveChanges = await this.db.SaveChangesAsync();
            
            return (saveChanges > 0) ? false : true; 
        }

        public async Task<RANGO_DE_PESO> Buscar(int? id)
        {
            var dato = await this.db.rango_de_peso.FindAsync(id);

return (dato == null) ? null : dato;        }

        public async Task<Boolean> Actualizar(int? id, RANGO_DE_PESO rango_de_peso)
        {
            var entidad = await db.rango_de_peso.FindAsync(id);

            if (entidad != null)
            {
                entidad = rango_de_peso;
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
            var entidad = await db.rango_de_peso.FindAsync(id);

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