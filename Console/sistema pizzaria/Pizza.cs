using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_pizzaria
{
    internal class Pizza
    {
        public string Sabor { get; set; }
        public int Preco { get; set; }
        public string Tamanho { get; set; }

        public virtual void Exibir()
        {
            Console.WriteLine("Pizza");
        }

    }
}
