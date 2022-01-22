using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Dominio.Entidades;

namespace WebApp.Repositorio.Contexto
{
    public class WebAppContexto: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


        public WebAppContexto(DbContextOptions options) : base(options)
        {
        }

    }
}
