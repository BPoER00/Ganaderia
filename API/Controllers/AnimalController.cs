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
    public class AnimalController : ControllerBase
    {

        private AnimalesActions db;

        public AnimalController(ConexionContext _db)
        {
            this.db = new AnimalesActions(_db);
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
        public async Task<Reply> Post(ANIMAL animal)
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

                var resultAction = await this.db.guardar(animal);

                return new Reply
                {
                    code = resultAction.code,
                    data = resultAction.data,
                    message = resultAction.message,
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