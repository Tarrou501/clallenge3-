using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Dominio.Contratos;
using WebApp.Dominio.Entidades;
using WebApp.Repositorio.Contexto;

namespace WebApp.Repositorio.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(WebAppContexto webAppContexto) : base(webAppContexto)
        {

        }
    }
}
