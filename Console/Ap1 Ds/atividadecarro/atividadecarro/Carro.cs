using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadecarro
{
    internal class Carro
    {
        private String _cor;
        private String _modelo;
        private String _marca;
        private string _qt_assento;


        public Carro()
        {
            this._cor= null;
            this._modelo = null;
            this._marca= null;
            this._qt_assento = null;

        }
        public Carro(String novaCor, String novoModelo, String novaMarca, String novaQtAssento)
        {
            this._cor = novaCor;
            this._modelo = novoModelo;
            this._marca = novaMarca;
            this._qt_assento = novaQtAssento;

        }

        public String get_cor()
        {
            return this._cor;
        }

        public void set_cor(String novaCor)
        {
            this._cor = novaCor;
        }

        public String get_modelo()
        {
            return this._modelo;
        }

        public void set_modelo(String novoModelo)
        {
            this._modelo = novoModelo;
        }
        public String get_marca()
        {
            return this._marca;
        }
        public void set_marca(String novaMarca)
        {
            this._marca = novaMarca;
        }
        public String get_qtAssento()
        {
            return this._qt_assento;
        }
        public void set_qtAssento(String novaQtAssento)
        {
            this._qt_assento= novaQtAssento;
        }

        public void Andar()
        {
            Console.WriteLine("O carro foi para a Frente");
        }

        public void Direção()
        {
            Console.WriteLine("O carro virou para a Direita");
        }
    }

}
