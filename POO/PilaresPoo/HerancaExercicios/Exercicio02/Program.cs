using Exercicio02;

//Exercicio 2
Console.Clear();

Funcionario Giu = new Funcionario();
Giu.Nome = "Giulia";
Giu.CalcularSalario();

Gerente Mari = new Gerente();
Mari.Nome = "Maria";
Mari.BonusAdicional = 600f;
Mari.CalcularSalario();
