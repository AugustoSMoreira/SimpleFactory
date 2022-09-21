using SimpleFactoryPizzaria.Client;
using SimpleFactoryPizzaria.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPizzaria.Models
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(char tipo)
        {
            Pizza pizza;
            switch (tipo)
            {
                case 'C':
                    pizza = new PizzaMussarela();
                    break;
                case 'M':
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException($"A pizza de tipo '{tipo}' não existe");
                    Pizzaria.SolicitarPizza();
            }
            return pizza;
        }
    }
}
