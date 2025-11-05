using System.Reflection;
using Calculadora;

int opcao = -1;

Console.Clear();

Calculator Calc = new Calculator();


//Criar um cabeçalho de boas vindas
//Criar um menu de opções em loop
//ajustar o programa, conforme o menu

Console.Clear();
do
{
    Console.WriteLine($"==============================");
    Console.WriteLine($"========== Bem-vindo =========");
    Console.WriteLine($"============== a =============");
    Console.WriteLine($"========= Calculadora ========");
    Console.WriteLine($"==============================");

    Console.WriteLine($"Escolha uma opção:");
    Console.WriteLine($"");
    Console.WriteLine($"1) Soma");
    Console.WriteLine($"2) Subtração");
    Console.WriteLine($"3) Multiplicação");
    Console.WriteLine($"4) Divisão");
    Console.WriteLine($"0) Sair");

    Console.WriteLine($"Digite a opção desejada:");
    opcao = int.Parse(Console.ReadLine());

    if (opcao > 0 && opcao <=4)
    {
        Console.WriteLine($"Digite o primeiro número:");
        Calc.Numero1 = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o segundo número:");
        Calc.Numero2 = Double.Parse(Console.ReadLine());

    }



    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");

            break;

        case 1:

            Console.WriteLine($"Soma: {Calc.Somar()}");
            Console.WriteLine($"");

            break;

        case 2:

            Console.WriteLine($"Subtração: {Calc.Subtrair()}");
            Console.WriteLine($"");
            break;

        case 3:


            Console.WriteLine($"Multiplicação: {Calc.Multiplicar()}");
            Console.WriteLine($"");
            break;

        case 4:


            Console.WriteLine($"Divisão: {Calc.Dividir()}");
            Console.WriteLine($"");
            break;

        default:
            Console.WriteLine($"Opss opção inválida...");

            break;
    }


} while (opcao != 0);














// Calc.Numero1 = 50;
// Calc.Numero2 = 34;

// Console.WriteLine($"------==== CALCULATER ====------");
// Console.WriteLine($"Primeiro número: {Calc.Numero1}");
// Console.WriteLine($"Segundo número: {Calc.Numero2}");

// Console.WriteLine($"Resultados:");
// Console.WriteLine();











