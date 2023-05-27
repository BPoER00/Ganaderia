using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ganaderia.Actions;
using Ganaderia.Models;
using Microsoft.AspNetCore.Mvc;
using static Ganaderia.Helpers.ErrorHelpers;

namespace Ganaderia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CorralesController : ControllerBase
    {
        private CorralActions db;

        public CorralesController(ConexionContext _db)
        {
            this.db = new CorralActions(_db);
        }

        [HttpGet]
        public async Task<Reply> Get()
        {
            try
            {
                var responseAction = await this.db.Obtener();
            
                return new Reply{
                    code = (responseAction.Count > 0) ? 2 : 1,
                    data = responseAction,
                    message = (responseAction.Count > 0) ? "No se encontraron registros" : "Registros Obtenidos Correctamente"
                };
            }
            catch(Exception e)
            {
                    return new Reply{
                        code = 0,
                        data = null,
                        message = $"Error: {e.Message}"
                    };
            }
        }

        [HttpGet("{id}")]
        public async Task<Reply> Get(int? id)
        {
            try
            {
                var responseAction = await this.db.Buscar(id);
            
                return new Reply{
                    code = (responseAction != null) ? 2 : 1,
                    data = responseAction,
                    message = (responseAction != null) ? "No se encontro el campo con el id recibido" : "Registros encontrado correctamente"
                };
            }
            catch(Exception e)
            {
                    return new Reply{
                        code = 0,
                        data = null,
                        message = $"Error: {e.Message}"
                    };
            }
        }

        [HttpPost]
        public async Task<Reply> Post(CORRAL corral)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return new Reply{
                        code = 0,
                        data = ErrorHelper.GetModelStateErrors(ModelState),
                        message = "Hay campos que no se enviaron correctamente"
                    };
                }
                
                var responseAction = await this.db.Guardar(corral);

                return new Reply{
                    code = (responseAction == true) ? 0 : 1,
                    data = responseAction,
                    message = (responseAction == true) ? "La informacion no fue guardada" : "La informacion se guardo correctamente"
                };
            }
            catch(Exception e)
            {
                    return new Reply{
                        code = 0,
                        data = null,
                        message = $"Error: {e.Message}"
                    };
            }
        }

        [HttpPut("{id}")]
        public async Task<Reply> Put(int? id, CORRAL corral)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return new Reply{
                        code = 0,
                        data = ErrorHelper.GetModelStateErrors(ModelState),
                        message = "Hay campos que no se enviaron correctamente"
                    };
                }
                
                var responseAction = await this.db.Actualizar(id, corral);

                return new Reply{
                    code = (responseAction == true) ? 0 : 1,
                    data = responseAction,
                    message = (responseAction == true) ? "La informacion no fue actualizada" : "La informacion se actualizo correctamente"
                };
            }
            catch(Exception e)
            {
                    return new Reply{
                        code = 0,
                        data = null,
                        message = $"Error: {e.Message}"
                    };
            }
        }

        [HttpDelete("{id}")]
        public async Task<Reply> Delete(int? id)
        {
            try
            {
                var responseAction = await this.db.Eliminar(id);

                return new Reply{
                    code = (responseAction == true) ? 0 : 1,
                    data = responseAction,
                    message = (responseAction == true) ? "La informacion no fue Eliminada" : "La informacion se Elimino correctamente"
                };
            }
            catch(Exception e)
            {
                    return new Reply{
                        code = 0,
                        data = null,
                        message = $"Error: {e.Message}"
                    };
            }
        }
    }
}