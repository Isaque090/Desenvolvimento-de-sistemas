
using atividadejogador;

Jogador j = new Jogador();
j.set_nome("Cassio Roberto");
j.set_posição("Goleiro");
j.set_time("Cruzeiro");
j.set_idade("38");


Console.WriteLine(string.Concat("Nome:", j.get_nome(), "\nPosição:", j.get_posição(), "\nTime:", j.get_time(), "\nIdade:", j.get_idade()));
j.Golmarcado();
j.Treinamento();
