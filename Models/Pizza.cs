using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPizzaria.Models
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempo);
        public abstract void Embalar();
    }
}
