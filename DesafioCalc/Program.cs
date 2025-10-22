//Pedir para o usuario digitar e exibir a soma desses dois numeros
using System.Runtime.InteropServices;

int n1, n2;

Console.WriteLine("Digite o primeiro número:");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
n2 = int.Parse(Console.ReadLine());

int soma = n1 + n2;

Console.WriteLine($"O resultado da soma é {soma}");

