using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovirrede_funcionario
{
    internal class Guerreiro : Personagens
    {

        public override void Atacar()
        {

            Console.WriteLine("Ataque:Ataque Corpo a Corpo");
        }
        public override void UsarHabilidade()
        {

            Console.WriteLine("Habilidade:Machado Eletrico");
        }
        public override void CalcularDano()
        {
            Console.WriteLine("Dano:Dano Fisico Alto");

        }

    }
}
