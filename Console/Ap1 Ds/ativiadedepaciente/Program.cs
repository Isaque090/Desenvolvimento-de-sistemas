
using ativiadedepaciente;

Paciente p = new Paciente();
p.set_nome("Isaque Severo");
p.set_data_nascimento("21/09/2009");
p.set_sintomas("Tosse");
p.set_cpf("123.456.789-01");

Console.WriteLine(string.Concat("Nome:", p.get_nome(), "\nData de Nascimento:", p.get_data_nascimento(), "\nSintomas:", p.get_sintomas(), "\nCpf:", p.get_cpf()));
p.Medicamento();
p.Gravidade();

