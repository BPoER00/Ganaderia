using Microsoft.EntityFrameworkCore;
using Ganaderia.Models;

namespace Ganaderia.Actions
{
    public class AnimalesActions
    {
        private ConexionContext db;

        public AnimalesActions(ConexionContext _db)
        {
            this.db = _db;
        }

        public async Task<List<ANIMAL>> Obtener()
        {
            List<ANIMAL> lista = await this.db.animal
                                    .Where(x => x.estado == 1)
                                    .ToListAsync();

            return lista;
        }

        public async Task<Reply> Guardar(ANIMAL animal)
        {
            Reply result = await this.ActualizarCorral(animal.id_corral, true);

            if(result.code == 0 || result.code == 2)
            {
                return new Reply
                {
                    code = 0,
                    data = null,
                    message = result.message
                };
            }
            else
            {
                this.db.animal.Add(animal);
                int saveChanges = await this.db.SaveChangesAsync();

                return new Reply
                {
                    code = 1,
                    data = (saveChanges < 0) ? false : true,
                    message = "animal guardado correctamente"
                };   
            }
        }

        public async Task<ANIMAL> Buscar(int? id)
        {
            var dato = await this.db.animal.FindAsync(id);

            return (dato == null) ? null : dato;
        }

        public async Task<Boolean> Actualizar(int? id, ANIMAL animal)
        {
            var entidad = await db.animal.FindAsync(id);

            if (entidad != null)
            {
                entidad = animal;
                int saveChanges = await db.SaveChangesAsync();

                return (saveChanges < 0) ? false : true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Reply> Eliminar(int? id)
        {
            var entidad = await db.animal.FindAsync(id);

            if (entidad != null)
            {
                Reply result = await this.ActualizarCorral(entidad.id_corral, false);

                if(result.code == 0 || result.code == 2)
                {
                    return new Reply
                    {
                        code = 0,
                        data = null,
                        message = result.message
                    };
                }
                else
                {
                    entidad.estado = 0;
                    int saveChanges = await this.db.SaveChangesAsync();

                    return new Reply
                    {
                        code = (saveChanges < 0) ? 0 : 1,
                        data = (saveChanges < 0) ? false : true,
                        message = (saveChanges < 0) ? "animal no fue eliminado correctamente" : "animal eliminado correctamente"
                    };   
                }

            }
            else
            {
                return new Reply
                {
                    code = 0,
                    data = false,
                    message = "animal no encontrado"
                };            }
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
                        code = (saveChanges < 0) ? 0 : 1,
                        data = null,
                        message = (saveChanges < 0) ? "No fueron guardados los datos" : "Agragada al corral Correctamente"
                    };

                }
                else
                {
                    entidad.cantidad_actual = (entidad.cantidad_actual < 0) ? entidad.cantidad_actual = 0 : entidad.cantidad_actual -= 1;

                    int saveChanges = await this.db.SaveChangesAsync();

                    return new Reply
                    {
                        code = (saveChanges < 0) ? 0 : 1,
                        data = null,
                        message = (saveChanges < 0) ? "No fueron guardados los datos" : "Eliminada del corral Correctametne"
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