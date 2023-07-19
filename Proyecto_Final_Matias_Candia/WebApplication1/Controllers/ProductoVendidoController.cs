using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Controllers.DTOs;
using Proyecto_Final.Objetos;
using Proyecto_Final.ADO.NET;

namespace Proyecto_Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "TraerProductosVendidos")]
        public List<ProductoVendido> TraerProductosVendidos_conIdUsuario(long idUsuario)
        {
            return ProductoVendidoHandler.TraerProductosVendidos_conIdUsuario(idUsuario);
        }
    }
}
