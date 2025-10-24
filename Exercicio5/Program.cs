//5) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
//Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

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
