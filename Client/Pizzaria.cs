using SimpleFactoryPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPizzaria.Client
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("===========Pizzaria===========");
            Console.Write("Informe a Pizza (C)alabreza ou (M)ussarela:  ");
            char.TryParse(Console.ReadLine().ToUpper(), out char tipo);

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
            }
        }
    }
}
