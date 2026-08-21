using sistema_pizzaria;

Usuario u = new Usuario();

Console.Write("Digite seu nome: ");
u.Nome = Console.ReadLine();

Console.Write("Digite seu CPF: ");
u.Cpf = Console.ReadLine();

Console.Write("Digite seu endereço: ");
u.Endereco = Console.ReadLine();

Console.Clear();


Pedido pe = new Pedido();
PizzaSalgada pizzasal= new PizzaSalgada();
PizzaDoce pizzadoce = new PizzaDoce();
List<PizzaSalgada> pizzasSalgadas = new List<PizzaSalgada>()
{
    new PizzaSalgada { Sabor = "Calabresa", Preco = 45, Tamanho = "Medio", TipoQueijo = "Mussarela"  },
    new PizzaSalgada { Sabor = "Mussarela", Preco = 40 , Tamanho = "Medio", TipoQueijo = "Mussarela" },
    new PizzaSalgada { Sabor = "Portuguesa", Preco = 50 ,  Tamanho= "Grande", TipoQueijo = "Quatro Queijos"  }
};

List<PizzaDoce> pizzasDoces = new List<PizzaDoce>()
{
  new PizzaDoce { Sabor = "Chocolate", Preco = 50, Tamanho = "Médio" ,TipoChocolate = "Ao Leite"},
    new PizzaDoce { Sabor = "Chocolate com Morango", Preco = 55, Tamanho = "Grande",TipoChocolate = "Ao Leite" },
    new PizzaDoce { Sabor = "Brigadeiro", Preco = 50, Tamanho = "Médio",TipoChocolate = "Meio Amargo" },
};

int escolha3 = 10, escolha2 = 10, escolha = 10;
escolha = 10;
while (escolha != 0) {
    Console.Write("---- MENU ----\n1-Pizza\n0-Fechar pedido\nEscolha uma opção:");
    escolha = int.Parse(Console.ReadLine());



    Console.Clear();
    switch (escolha)
    {
        case 1:
            escolha2 = 10;
            while (escolha2 != 0)
            {
                Console.Write("---- MENU ----\n1-Salgada\n2-Doce\n0-Voltar\nEscolha uma opção:");
                escolha2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha2)
                {

                    case 1:
                        escolha3 = 10;
                        while (escolha3 != 0)
                        {
                            pizzasal.Exibir();
                            for (int i = 0; i < pizzasSalgadas.Count; i++)
                            {
                                Console.WriteLine($"Pizza {i + 1}");
                                Console.WriteLine($"Sabor: {pizzasSalgadas[i].Sabor}");
                                Console.WriteLine($"Tamanho: {pizzasSalgadas[i].Tamanho}");
                                Console.WriteLine($"Tipo de Queijo: {pizzasSalgadas[i].TipoQueijo}");
                                Console.WriteLine($"Preço: R$ {pizzasSalgadas[i].Preco},00");
                                Console.WriteLine("------------------------");
                            }
                            Console.Write("0-Voltar\nEscolha uma opção:");
                            escolha3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (escolha3)
                            {
                                case 1:
                                    pe.Pizzas.Add(pizzasSalgadas[0]);
                                    pe.Total += pizzasSalgadas[0].Preco;
                                    break;

                                case 2:
                                    pe.Pizzas.Add(pizzasSalgadas[1]);
                                    pe.Total += pizzasSalgadas[1].Preco;
                                    break;

                                case 3:
                                    pe.Pizzas.Add(pizzasSalgadas[2]);
                                    pe.Total += pizzasSalgadas[2].Preco;
                                    break;

                            }
                        }
                        break;

                    case 2:
                        escolha3 = 10;
                        while (escolha3 != 0)
                        {
                            pizzadoce.Exibir();
                            for (int i = 0; i < pizzasDoces.Count; i++)
                            {
                                Console.WriteLine($"Pizza {i + 1}");
                                Console.WriteLine($"Sabor: {pizzasDoces[i].Sabor}");
                                Console.WriteLine($"Tamanho: {pizzasDoces[i].Tamanho}");
                                Console.WriteLine($"Tipo de Chocolate: {pizzasDoces[i].TipoChocolate}");
                                Console.WriteLine($"Preço: R$ {pizzasDoces[i].Preco},00");
                                Console.WriteLine("------------------------");
                            }      
                            Console.Write("0-Voltar\nEscolha uma opção:");
                            escolha3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            switch (escolha3)
                            {
                                case 1:
                                    pe.Pizzas.Add(pizzasDoces[0]);
                                    pe.Total += pizzasDoces[0].Preco;
                                    break;

                                case 2:
                                    pe.Pizzas.Add(pizzasDoces[1]);
                                    pe.Total += pizzasDoces[1].Preco;
                                    break;

                                case 3:
                                    pe.Pizzas.Add(pizzasDoces[2]);
                                    pe.Total += pizzasSalgadas[2].Preco;
                                    break;


                            }
                        }
                        break;
                }

            }
            break;

        case 0:
            Console.WriteLine("=== DADOS DO CLIENTE ===");
            Console.WriteLine($"Nome: {u.Nome}");
            Console.WriteLine($"CPF: {u.Cpf}");
            Console.WriteLine($"Endereço: {u.Endereco}\n");

            Console.WriteLine("=== PEDIDO ===");
            pe.Id = 456;
            Console.WriteLine($"NUMERO DO PEDIDO:#{pe.Id}\n");
            foreach (Pizza pizza in pe.Pizzas)

            {
                Console.WriteLine($"{pizza.Sabor} - R$ {pizza.Preco},00");
            }

            Console.WriteLine($"\nTotal: R$ {pe.Total},00");
            break;


    } 
}


