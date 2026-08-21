using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadejogador
{
    internal class Jogador
    {
        private String _nome;
        private String _posição;
        private String _time;
        private string _idade;


        public Jogador()
        {
            this._nome = null;
            this._posição = null;
            this._time = null;
            this._idade = null;

        }
        public Jogador(String novoNome, String novaPosição, String novoTime, String novaIdade)
        {
            this._nome = novoNome;
            this._posição = novaPosição;
            this._time = novoTime;
            this._idade = novaIdade;

        }

        public String get_nome()
        {
            return this._nome;
        }

        public void set_nome(String novoNome)
        {
            this._nome = novoNome;
        }

        public String get_posição()
        {
            return this._posição;
        }

        public void set_posição(String novaPosição)
        {
            this._posição = novaPosição;
        }
        public String get_time()
        {
            return this._time;
        }
        public void set_time(String novoTime)
        {
            this._time = novoTime;
        }
        public String get_idade()
        {
            return this._idade;
        }
        public void set_idade(String novaIdade)
        {
            this._idade = novaIdade;
        }

        public void Treinamento()
        {
            Console.WriteLine("Treinamento:Defesa");
        }

        public void Golmarcado()
        {
            Console.WriteLine("Gols Marcados:0");
        }


    }

}