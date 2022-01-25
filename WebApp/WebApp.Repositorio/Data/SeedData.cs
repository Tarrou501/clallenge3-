using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Dominio.Entidades;
using WebApp.Repositorio.Contexto;

namespace WebApp.Repositorio.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppContexto(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppContexto>>()))
            {
                if (context == null || context.Clientes == null)
                {
                    throw new ArgumentNullException("WebAppContexto Nulo");
                }

                // Look for any movies.
                if (context.Clientes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Clientes.AddRange(
                    new Cliente
                    {
                        Nome = "Jose",
                        SobreNome ="Aparecido Borges",
                        Cpf ="10929309800",
                        DataNasc = DateTime.Parse("1989-2-12"),
                        Profissao =1
                    },
                    new Cliente
                    {
                        Nome = "Maria",
                        SobreNome = "Silva Jota",
                        Cpf = "10929309101",
                        DataNasc = DateTime.Parse("1970-03-15"),
                        Profissao = 1
                    },
                    new Cliente
                    {
                        Nome = "Isabela",
                        SobreNome = "Minus",
                        Cpf = "10929309101",
                        DataNasc = DateTime.Parse("1971-03-20"),
                        Profissao = 1
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
