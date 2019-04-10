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
    }
}
