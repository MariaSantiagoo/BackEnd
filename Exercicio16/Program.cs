//Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo,
//Produção - 6.5
//Administrativo - 7.5
// Diretoria - 12

//salario = salario * 1.65

//De acordo com a tabela acima faça um programa que receba o cargo e o salário de um funcionário e calcule e imprima o salário reajustado.

double salario, salarioReajustado;
string cargo;

Console.WriteLine("Digite seu cargo: Produção, Administrativo ou Diretoria");
cargo = (Console.ReadLine());

Console.WriteLine("Digite seu salário");
salario = double.Parse(Console.ReadLine());

if (cargo == "Produção")
{
    salarioReajustado = salario * 1.065;
    Console.WriteLine($"Novo Salário: R${salarioReajustado}");
}
else if (cargo == "Administrativo")
{
    salarioReajustado = salario * 1.075;
    Console.WriteLine($"Novo Salário: R${salarioReajustado}");
    
}
else if (cargo == "Diretoria")
{
    salarioReajustado = salario * 1.12;
    Console.WriteLine($"Novo Salário: R${salarioReajustado}");

}
else
{
    Console.WriteLine("Cargo inválido");
    return;
}


