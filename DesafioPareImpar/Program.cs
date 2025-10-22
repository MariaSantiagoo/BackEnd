//Perguntar ao usuario quantos numeros ele quer digitar
//exibir, separadamente, os números pares e os nomeros impares que ele digitar

int qtdNumeros = 0;
string pares = "Pares: ";
string impares = "Ímpares: ";

Console.WriteLine($"Olá, quantos numeros deseja digitar?");
qtdNumeros = int.Parse(Console.ReadLine());

for (int i = 0; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado % 2 == 0)
    {
        pares += numeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += numeroDigitado.ToString() + ", ";
    }
}

Console.Clear();
Console.WriteLine("Resultado");
Console.WriteLine();
Console.WriteLine(pares);
Console.WriteLine(impares);


