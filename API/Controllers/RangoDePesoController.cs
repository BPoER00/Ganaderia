using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Actions;
using API.Helpers;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RangoDePesoController : ControllerBase
    {
        private RangoDePesosActions db;

        public RangoDePesoController(ConexionContext _db)
        {
            this.db = new RangoDePesosActions(_db);
        }

        [HttpGet]
        public async Task<Reply> Get()
        {
            try
            {
                var resultAction = await this.db.obtener();
                return new Reply
                {
                    code = (resultAction.Count != 0) ? 1 : 0,
                    data = (resultAction.Count != 0) ? resultAction : null,
                    message = (resultAction.Count != 0) ? "Datos obtenidos correctamente" : "No se han encontrado datos"
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
        public async Task<Reply> Post(RANGO_DE_PESO rango)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return new Reply{
                        code = 0,
                        data = ErrorHelper.GetModelStateErrors(ModelState),
                        message = "Campos Invalidos"
                    };
                }

                var resultAction = await this.db.guardar(rango);

                return new Reply
                {
                    code = (resultAction == true) ? 1 : 0,
                    data = resultAction,
                    message = (resultAction == true) ? "Datos guardados correctamente" : "Los datos no fueron guardados correctamente",
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