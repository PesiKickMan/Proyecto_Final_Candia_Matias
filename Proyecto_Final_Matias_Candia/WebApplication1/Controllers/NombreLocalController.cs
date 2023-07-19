using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Controllers.DTOs;
using Proyecto_Final.ADO.NET;

namespace Proyecto_Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NombreLocalController : ControllerBase
    {
        [HttpGet(Name = "TraerNombreDelLocal")] 
        public string TraerNombreDelLocal()
        {
            return "Los Pollos Hermanos";
        }
    }
}
