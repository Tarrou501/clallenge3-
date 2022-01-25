using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApp.Dominio.Contratos;
using WebApp.Dominio.Entidades;

namespace WebApp.API.Controllers
{
    [EnableCors]
    [Route("api/[Controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_clienteRepositorio.ObterTodos());
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        //[Route("Recuperar/{id}")]
       // public IActionResult Recuperar(int id)
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_clienteRepositorio.ObterPorId(id));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Adicionar(cliente);
                return Created("api/cliente", cliente);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            try
            {
                _clienteRepositorio.Atualizar(cliente);
                return Created("api/cliente", cliente);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete]
        [Route("Excluir/{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                var cliente = _clienteRepositorio.ObterPorId(id);
                if (cliente != null)
                {
                    _clienteRepositorio.Atualizar(cliente);
                    return Ok(cliente);
                }
                else
                {
                    return BadRequest($"Id não eocnotrado {id}");
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}
