using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadefilme
{
    internal class Filme
    {
        private String _nome;
        private String _sinopse;
        private String _categoria;
        private string _ano_lançamento;


        public Filme()
        {
            this._nome = null;
            this._sinopse = null;
            this._categoria = null;
            this._ano_lançamento = null;

        }
        public Filme(String novoNome, String novaSinopse, String novaCategoria, String novoAnoLançamento)
        {
            this._nome = novoNome;
            this._sinopse = novaSinopse;
            this._categoria = novaCategoria;
            this._ano_lançamento = novoAnoLançamento;

        }

        public String get_nome()
        {
            return this._nome;
        }

        public void set_nome(String novoNome)
        {
            this._nome = novoNome;
        }

        public String get_sinopse()
        {
            return this._sinopse;
        }

        public void set_sinopse(String novaSinopse)
        {
            this._sinopse = novaSinopse;
        }
        public String get_categoria()
        {
            return this._categoria;
        }
        public void set_categoria(String novaCategoria)
        {
            this._categoria = novaCategoria;
        }
        public String get_anoLançamento()
        {
            return this._ano_lançamento;
        }
        public void set_anoLançamento(String novoAnoLançamento)
        {
            this._ano_lançamento = novoAnoLançamento;
        }
        public void MinutoPausado()
        {
            Console.WriteLine("O filme foi pausado no minuto:50:40");
        }

        public void DuraçãoFilme()
        {
            Console.WriteLine("Duração:2h 49m");
        }
    }

}
