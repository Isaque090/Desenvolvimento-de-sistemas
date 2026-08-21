using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pizzaria
{
    internal class Pedido
    {
        public int Id { get; set; }
     
        public Usuario Cliente { get; set; }

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public double Total { get; set; }
    }
}
