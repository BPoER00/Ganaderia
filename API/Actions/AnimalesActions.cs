using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Actions
{
    public class AnimalesActions
    {
        private ConexionContext db;

        public AnimalesActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<ANIMAL>> obtener()
        {
            var lista = await this.db.animal
                                .Where(x => x.estado == ANIMAL.ACTIVO)
                                .ToListAsync();
            
            return lista;
        }

        public async Task<Reply> guardar(ANIMAL animal)
        {
            var respuesta = await this.ActualizarCorral(animal.id_corral, true);
            if(respuesta.code == 0 || respuesta.code == 2)
            {
                return new Reply
                {
                    code = 0,
                    data = null,
                    message = respuesta.message
                };
            }
            else
            {
                this.db.animal.Add(animal);
                int saveChanges = await this.db.SaveChangesAsync();
                
                return new Reply
                {
                    code = (saveChanges != 0) ? 1 : 0,
                    data = animal,
                    message = (saveChanges != 0) ? "Guardado correctamente" : "No fue guardado correctamente"
                };
            }

        }

        public async Task<Reply> ActualizarCorral(int? id, Boolean opcion)
        {
            var entidad = await db.corral.FindAsync(id);

            if (entidad != null)
            {
                if (opcion == true)
                {
                    if (entidad.cantidad_actual == entidad.cantidad_corral)
                    {
                        return new Reply
                        {
                            code = 2,
                            data = null,
                            message = "corral lleno"
                        };
                    }

                    entidad.cantidad_actual += 1;
                    int saveChanges = await this.db.SaveChangesAsync();

                    return new Reply
                    {
                        code = (saveChanges > 0) ? 0 : 1,
                        data = null,
                        message = (saveChanges > 0) ? "No fueron guardados los datos" : "Agragada al corral Correctamente"
                    };

                }
                else
                {
                    entidad.cantidad_actual = (entidad.cantidad_actual < 0) ? entidad.cantidad_actual = 0 : entidad.cantidad_actual -= 1;

                    int saveChanges = await this.db.SaveChangesAsync();

                    return new Reply
                    {
                        code = (saveChanges > 0) ? 0 : 1,
                        data = null,
                        message = (saveChanges > 0) ? "No fueron guardados los datos" : "Eliminada del corral Correctametne"
                    };
                }
            }
            else
            {
                return new Reply
                {
                    code = 0,
                    data = null,
                    message = "Corral no encontrado"
                };
            }

        }
    }
}