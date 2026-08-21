using Ovirrede_funcionario;

Personagens p1 = new Guerreiro();
Personagens p2 = new Mago();
Personagens p3 = new Arqueiro();

p1.Nome = "Thor";
p1.Vida = "200";
p1.Nivel = "15";

Console.WriteLine("Nome:"+p1.Nome);
Console.WriteLine("Vida:"+p1.Vida);
Console.WriteLine("Nivel:" + p1.Nivel);

p1.Atacar();
p1.UsarHabilidade();
p1.CalcularDano();
Console.WriteLine("----------------//----------------");

p2.Nome = "Merlin";
p2.Vida = "100";
p2.Nivel = "20";

Console.WriteLine("Nome:"+p2.Nome);
Console.WriteLine("Vida:"+p2.Vida);
Console.WriteLine("Nivel:" + p2.Nivel);
p2.Atacar();
p2.UsarHabilidade();
p2.CalcularDano();
Console.WriteLine("----------------//----------------");

p3.Nome = "Legolas";
 p3.Nivel = "18";

Console.WriteLine("Nome:" + p3.Nome);
Console.WriteLine("Vida:" + p3.Vida);
Console.WriteLine("Nivel:" + p3.Nivel);
p3.Atacar();
p3.UsarHabilidade();
p3.CalcularDano();
Console.WriteLine("----------------//----------------");