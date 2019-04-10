using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaWeb.Models
{
    public class Rebanho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Origem { get; set; }
        public Pasto Pasto { get; set; }

        public Rebanho()
        {

        }

        public Rebanho(int id, string nome, DateTime dataNascimento, string raca, string sexo, string origem, Pasto pasto)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Raca = raca;
            Sexo = sexo;
            Origem = origem;
            Pasto = pasto;
        }

      
    }
}
