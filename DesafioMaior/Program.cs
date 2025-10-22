using System.Linq.Expressions;
using System.Runtime.InteropServices;

int n1, n2;

Console.WriteLine("Digite o primeiro número:");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro número é maior que o segundo: {n1}");
}
else if (n1 < n2)
{
    Console.WriteLine($"o segundo número é maoir que o primeiro: {n2}");
}
else
{
    Console.WriteLine($"Os números são iguais: {n1}, {n2}");
}
