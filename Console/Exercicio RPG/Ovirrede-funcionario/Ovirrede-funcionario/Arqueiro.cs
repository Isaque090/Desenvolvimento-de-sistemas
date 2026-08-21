using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovirrede_funcionario
{
    internal class Arqueiro:Personagens
    {
        public override void Atacar()
        {

            Console.WriteLine("Ataque:Ataque A Distancia");
        }
        public override void UsarHabilidade()
        {

            Console.WriteLine("Habilidade:Dança das Flechas");
        }
        public override void CalcularDano()
        {
            Console.WriteLine("Dano:Dano Medio");

        }

    }
}
