using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pizzaria
{
    internal class PizzaDoce:Pizza
    {

        public string TipoChocolate { get; set; }

        public override void Exibir()
        {
            Console.WriteLine("---- Pizza Doce ----\n");
        }
    }
}
