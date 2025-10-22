//.Faça um programa que solicite ao usuário um número de repetições “x”. Para cada
//repetição solicite dois números e imprima qual é o maior deles.

int x = 0;
int contador = 1;

Console.WriteLine($"Quantos números você quer digitar?");
x = int.Parse(Console.ReadLine());

while (contador <= x)
{
    Console.WriteLine($"Digite o primeiro número:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o segundo número:");
    int n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O número {n1} é maior que {n2}");
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"O número {n2} é maior que {n1}");
    }
    else
    {
        Console.WriteLine($"{n1} e {n2} são iguais!!:P");
    }

    contador++;
}