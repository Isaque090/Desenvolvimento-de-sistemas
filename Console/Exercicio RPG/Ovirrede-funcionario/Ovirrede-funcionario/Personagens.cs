using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovirrede_funcionario
{
    internal class Personagens
    {
        public string Nome { get; set; }
        public string Vida { get; set; }
        public string Nivel { get; set; }

        public virtual void Atacar()
        {

            Console.WriteLine("nada");
        }
        public virtual void UsarHabilidade()
        {

            Console.WriteLine("nada");
        }
        public virtual void CalcularDano()
        {
            Console.WriteLine("nada");
           
        }


    }
}
