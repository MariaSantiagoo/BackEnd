int opcao;

do
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("            Bem Vindo          ");
    Console.WriteLine("               ao              ");
    Console.WriteLine("          Menu Exercicios      ");
    Console.WriteLine("-------------------------------");
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Escolha uma opção no menu abaixo:");
    Console.WriteLine();

    Console.WriteLine(" 1.Exercicio 01 ");
    Console.WriteLine(" 2.Exercicio 02 ");
    Console.WriteLine(" 3.Exercicio 03 ");
    Console.WriteLine(" 4.Exercicio 04 ");
    Console.WriteLine(" 5.Exercicio 05 ");
    Console.WriteLine(" 6.Exercicio 06 ");
    Console.WriteLine(" 7.Exercicio 07 ");
    Console.WriteLine(" 0.Sair");
    Console.WriteLine("Opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine();
        break;

        case 1:
                Exercicio01();
        break;

        case 2:
                Exercicio02();
        break;

        case 3:
                Exercicio03();
        break;

        case 4:
                Exercicio04();
        break;

        case 5:
                Exercicio05();
        break;

        case 6:
                Exercicio06();
        break;
        
        case 7:
                Exercicio07();
            break;
        default:
            Console.WriteLine($"Opção inválida!:(");
            break;
        

    }


     Console.WriteLine($"Digite <Enter> para continuar");
     Console.ReadLine();
     

} while (opcao != 0);


void Exercicio01()
{
    float salario, gasto;

    Console.WriteLine("Olá, digite seu salário");
    salario = float.Parse(Console.ReadLine());

    Console.WriteLine("Agora, digite seus gastos");
    gasto = float.Parse(Console.ReadLine());

    if (salario >= gasto)
    {
        Console.WriteLine("Gastos dentro do orçamento");
    }
    else
    {
        Console.WriteLine("Orçamento estourado");
    }
}

void Exercicio02()
{

int gol1, gol2;


Console.WriteLine("Quantos gols o primeiro time fez?");
gol1 = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos gols o segundo time fez?");
gol2 = int.Parse(Console.ReadLine());


if (gol1 > gol2)
{
    Console.WriteLine($"O primeiro time ganhou com: {gol1} gols");
}
else if (gol2 > gol1)
{
    Console.WriteLine($"O segundo time ganhou com: {gol2} gols");
}
else
{
    Console.WriteLine("Houve um empate");
}
}

void Exercicio03()
{
   float lado1, lado2, lado3;

Console.WriteLine("Qual é a medida do primeiro lado?");
lado1 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é a medida do segundo lado?");
lado2 = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é a medida do terceiro lado?");
lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
{
    Console.WriteLine("Triângulo Equilátero");
}

else if (lado1 == lado2)
{
    Console.WriteLine("Triângulo Isóscele");
}

else
{
    Console.WriteLine("Triângulo Escaleno");
}
}

void Exercicio04()
{

    int senhaCorreta = 1234;
    int senhaInserida;

    Console.WriteLine("Insira a senha");
    senhaInserida = int.Parse(Console.ReadLine());

    if (senhaInserida == senhaCorreta)
    {
        Console.WriteLine("Acesso permitido");
    }

    else
    {
        Console.WriteLine("Acesso negado");
    }

}

void Exercicio05()
{
    int qtdmacas;


    Console.WriteLine($"Olá! Quantas maçãs você deseja comprar?");
    qtdmacas = int.Parse(Console.ReadLine());

    if (qtdmacas < 12)
    {
        float valordacompra = qtdmacas * 0.30f;
        Console.WriteLine($"Total da compra: {valordacompra}");
    }
    else
    {
        float valordacompra = qtdmacas * 0.25f;
        Console.WriteLine($"Total da compra: {valordacompra}");
    }
}

void Exercicio06()
{
    float media, frequencia;

    Console.WriteLine($"Insira sua frequência");
    frequencia = float.Parse(Console.ReadLine());


    Console.WriteLine($"Insira sua media");
    media = float.Parse(Console.ReadLine());

    if (media >= 7 && frequencia >= 75)
    {
        Console.WriteLine($"Aprovado");

    }
    else if (media > 3 && media < 7 && frequencia >= 75)
    {
        Console.WriteLine($"Rprovado, mas você tem direito a uma ultima avaliação de recuperação");
    }
    else
    {
        Console.WriteLine($"Reprovado");

    }
}

void Exercicio07()
{
    int opcao;


//rodar o menu em loop
//o menu deve aparecer/rodar pelo o menos 1 vez

do
{
    Console.Clear();
    Console.WriteLine($"-------------------------------------------------------");
    Console.WriteLine($"                        Bem vindo                      ");
    Console.WriteLine($"                           ao                          ");
    Console.WriteLine($"                      Jacareca food                    ");
    Console.WriteLine($"-------------------------------------------------------");

    Console.WriteLine($"");
    Console.WriteLine($"");

    Console.WriteLine($"Escolha uma opção do menu abaixo:");
    Console.WriteLine($"");

    Console.WriteLine($"    1. Hot roll ........................ R$ 29,90");
    Console.WriteLine($"    2. Temaki   ........................ R$ 30,00");
    Console.WriteLine($"    3. Sashimi  ........................ R$ 67,90");
    Console.WriteLine($"    4. Yakisoba ........................ R$ 35,90");
    Console.WriteLine($"    5. Guioza   ........................ R$ 49,90");
    Console.WriteLine($"    6. Shimeji  ........................ R$ 50,90");
    Console.WriteLine($"    0. Sair");

    Console.Write($"Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            break;
        case 1:
            HotHoll();
            break;

        case 2:
            Temaki();
            break;

        case 3:
            Sashimi();
            break;

        case 4:
            Yakisoba();
            break;

        case 5:
            Guioza();
            break;

        case 6:
            Shimeji();
            break;
        default:
            Console.WriteLine($"Opção inválida:(");

            break;
    }


    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);


void HotHoll()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Hot Holl com carinho!;)");
}

void Temaki()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Temaki com carinho!;)");
}

void Sashimi()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Sashimi com carinho!;)");
}

void Yakisoba()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Yakisoba com carinho!;)");
}

void Guioza()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Guioza com carinho!;)");
}

void Shimeji()
{
    Console.WriteLine($"Boa escolha! Vamos preparar o seu Shimeji com carinho!;)");
}
}