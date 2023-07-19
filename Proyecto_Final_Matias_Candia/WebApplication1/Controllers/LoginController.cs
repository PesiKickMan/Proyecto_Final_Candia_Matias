using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Controllers.DTOs;
using Proyecto_Final.Objetos;
using Proyecto_Final.ADO.NET;

namespace Proyecto_Final.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet(Name = "InicioDeSesion")] 
        public Usuario InicioDeSesion(string nombreUsuario, string contraseña)
        {
            return UsuarioHandler.InicioDeSesion(nombreUsuario, contraseña);
        }
    }
}
