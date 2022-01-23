using Microsoft.AspNetCore.Mvc;
using WebApp.Dominio.Contratos;

namespace WebApp.API.Controllers
{
    [Route("api/[Controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
