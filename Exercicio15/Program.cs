using System.Net.Http.Headers;

float n1, n2, n3, n4;

Console.WriteLine("Digite a primeira nota:");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota:");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota:");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quarta nota:");
n4 = float.Parse(Console.ReadLine());

float media = (n1 + n2 + n3 + n4) / 4;

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (media >= 5)
{
    Console.WriteLine("Recuperação");
}

else
{
    Console.WriteLine("Reprovado");
}