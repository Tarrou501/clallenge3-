using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public int Idade { get; set; }

        public int Profissao { get; set; }

    }
}
