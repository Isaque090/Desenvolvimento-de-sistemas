using atividadeLanches;

Lanches l = new Lanches();
l.set_sabor("Salgado");
l.set_tipo("Hamburguer");
l.set_ingredientes("Pão,Carne,Queijo");
l.set_valor("15,00");


Console.WriteLine(string.Concat("Sabor:", l.get_sabor(), "\nTipo:", l.get_tipo(), "\nIngredientes:", l.get_ingredientes(), "\nValor:", l.get_valor()));
l.QuantidadenoEstoque();
l.Validade();

