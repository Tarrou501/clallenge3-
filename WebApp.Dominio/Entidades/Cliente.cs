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

        public int Idade {            
            get {
                return CalcularIdade();               
            }        
        }

        public System.Nullable<int> Profissao { get; set; }

        private int CalcularIdade()
        {
            DateTime dataAtual =  DateTime.Now;
            var dataAniv = DataNasc;
            if ((dataAtual.Month > DataNasc.Month) || (dataAtual.Month == DataNasc.Month && dataAtual.Day >= DataNasc.Day))
                return dataAtual.Year - DataNasc.Year;
            else if ((dataAtual.Month < DataNasc.Month) || (dataAtual.Month == DataNasc.Month && dataAtual.Day < DataNasc.Day))
                return (dataAtual.Year - DataNasc.Year) - 1;
            else
            {
                throw new InvalidOperationException("Inválido calculo de idade");
            }
        }
    }
}
