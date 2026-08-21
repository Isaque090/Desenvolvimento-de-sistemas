using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovirrede_funcionario
{
    internal class Mago:Personagens
    {
        public override void Atacar()
        {

            Console.WriteLine("Ataque:Magia");
        }
        public override void UsarHabilidade()
        {

            Console.WriteLine("Habilidade:Tornado Glacial");
        }
        public override void CalcularDano()
        {
            Console.WriteLine("Dano: Dano Variavel");

        }

    }
}
