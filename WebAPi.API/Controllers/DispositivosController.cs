using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interface;
using WebAPI.Model;

namespace WebAPi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispositivosController : ControllerBase
    {
        private readonly IDispositivoService _dispositivoService;

        public DispositivosController(IDispositivoService dispositivosService) 
        {
            _dispositivoService = dispositivosService;
        }

        [HttpPost]
        public ActionResult Add(DispositivosEntities materia)
        {
            _dispositivoService.Add(materia);
            return Ok();
        }
    }
}
