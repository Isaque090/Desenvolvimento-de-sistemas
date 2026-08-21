using atividadefilme;

Filme f = new Filme();
f.set_nome("Interestelar");
f.set_sinopse("A terrasofre uma...");
f.set_categoria("Ficção Cientifica");
f.set_anoLançamento("2014");


Console.WriteLine(string.Concat("Nome:", f.get_nome(), "\nSinopse:", f.get_sinopse(), "\ncategoria:", f.get_categoria(), "\nAno De Lançamento:", f.get_anoLançamento()));
f.DuraçãoFilme();
f.MinutoPausado();


