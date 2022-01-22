using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Dominio.Entidades;

namespace WebApp.Repositorio.Repositorios
{
    public class CadastroCliente
    {
        public CadastroCliente()
        {
            var clienteRepositorio = new ClienteRepositorio();
            var cliente = new Cliente();
            clienteRepositorio.Adicionar(cliente);
        }

    }
}
