using atividadecarro;

Carro c = new Carro();
c.set_cor("Vermelho");
c.set_modelo("corsa");
c.set_marca("chevrolet");
c.set_qtAssento("5");


Console.WriteLine(string.Concat("O modelo:",c.get_modelo(),"\nA marca:", c.get_marca(),"\nCor:",c.get_cor(),"Quantidade de assentos:",c.get_qtAssento()));
c.Andar();
c.Direção();

