using Construtores;

Console.Clear();
Pessoa Maria = new Pessoa("Maria Santiago", 18);
Pessoa Giulia = new Pessoa();
Giulia.Nome = "Giulia";
Giulia.Idade = 17;

Maria.ExibirDados();
Giulia.ExibirDados();