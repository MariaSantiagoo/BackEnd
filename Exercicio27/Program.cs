//Faça um programa que pergunte para o usuário a quantidade de números que ele
//quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
//se for PAR. Utilize a estrutura WHILE.

int qtdvezes = 1;
int contador = 1;

Console.WriteLine($"Quantos números você quer digitar?");
qtdvezes = int.Parse(Console.ReadLine());

while (contador <= qtdvezes)
{
    Console.WriteLine($"Digite o {contador}° numero");
    int numeroDigitado = int.Parse(Console.ReadLine());
    if (numeroDigitado % 2 == 0)
    {
        Console.WriteLine($"Número par digitado: {numeroDigitado}");
    }
    contador++;
}

