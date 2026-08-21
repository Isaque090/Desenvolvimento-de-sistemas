using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pizzaria
{
    internal class PizzaSalgada:Pizza
    {
      
        public string TipoQueijo { get; set; }
        public override void Exibir()
        {
            Console.WriteLine("---- Pizza Salgada ----\n");
        }
    }
}
