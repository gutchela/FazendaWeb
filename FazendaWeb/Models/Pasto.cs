using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaWeb.Models
{
    public class Pasto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Area { get; set; }
        public ICollection<Rebanho> Rebanhos { get; set; } = new List<Rebanho>();

        public Pasto()
        {

        }

        public Pasto(int id, string descricao, double area)
        {
            Id = id;
            Descricao = descricao;
            Area = area;
        }
        public void AddRebanho(Rebanho rebanho)
        {
            Rebanhos.Add(rebanho);
        }
        public void RemoveRebanho(Rebanho rebanho)
        {
            Rebanhos.Remove(rebanho);
        }

    }

}
