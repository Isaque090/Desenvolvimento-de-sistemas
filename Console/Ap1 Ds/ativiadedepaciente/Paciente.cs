using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ativiadedepaciente
{
    internal class Paciente
    {

            private String _nome;
            private String _data_nascimento;
            private String _sintomas;
            private string _cpf;


            public Paciente()
            {
                this._nome = null;
                this._data_nascimento = null;
                this._sintomas = null;
                this._cpf = null;

            }
            public Paciente(String novoNome, String novaDataNascimento, String novosintoma, String novoCpf)
            {
                this._nome = novoNome;
                this._data_nascimento = novaDataNascimento;
                this._sintomas = novosintoma;
                this._cpf = novoCpf;

            }

            public String get_nome()
            {
                return this._nome;
            }

            public void set_nome(String novoNome)
            {
                this._nome = novoNome;
            }

            public String get_data_nascimento()
            {
                return this._data_nascimento;
            }

            public void set_data_nascimento(String novaDataNascimento)
            {
                this._data_nascimento = novaDataNascimento;
            }
            public String get_sintomas()
            {
                return this._sintomas;
            }
            public void set_sintomas(String novosintoma)
            {
                this._sintomas = novosintoma;
            }
            public String get_cpf()
            {
                return this._cpf;
            }
            public void set_cpf(String novoCpf)
            {
                this._cpf = novoCpf;
            }
        public void Medicamento()
        {
            Console.WriteLine("Medicamento:Amoxicilina 500mg");
        }
        public void Gravidade()
        {
            Console.WriteLine("Gravidade:baixa");
        }




    }
}
