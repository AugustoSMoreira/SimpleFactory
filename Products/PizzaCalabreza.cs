using SimpleFactoryPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPizzaria.Products
{
    internal class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Calabreza";
        }
        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo}");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}");
            Console.WriteLine($"Pizza de {Nome}, Pronta!");
        }
    }
}
