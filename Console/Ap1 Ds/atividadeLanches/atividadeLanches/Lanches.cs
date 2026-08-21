using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeLanches
{
    internal class Lanches
    {
        private String _tipo;
        private String _sabor;
        private String _ingredientes;
        private string _valor;


        public Lanches()
        {
            this._tipo = null;
            this._sabor = null;
            this._ingredientes = null;
            this._valor = null;

        }
        public Lanches(String novoTipo, String novoSabor, String novoIngredientes, String novoValor)
        {
            this._tipo = novoTipo;
            this._sabor = novoSabor;
            this._ingredientes = novoIngredientes;
            this._valor = novoValor;

        }

        public String get_tipo()
        {
            return this._tipo;
        }

        public void set_tipo(String novoTipo)
        {
            this._tipo= novoTipo;
        }

        public String get_sabor()
        {
            return this._sabor;
        }

        public void set_sabor(String novoSabor)
        {
            this._sabor = novoSabor;
        }
        public String get_ingredientes()
        {
            return this._ingredientes;
        }
        public void set_ingredientes(String novoIngredientes)
        {
            this._ingredientes = novoIngredientes;
        }
        public String get_valor()
        {
            return this._valor;
        }
        public void set_valor(String novoValor)
        {
            this._valor = novoValor;
        }
        public void QuantidadenoEstoque()
        {
            Console.WriteLine("Quantidade No estoque:5");
        }

        public void Validade()
        {
            Console.WriteLine("Validade:Consumir Em até 2 Dias");
        }
    }

}
