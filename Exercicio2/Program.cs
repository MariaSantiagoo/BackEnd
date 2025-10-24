//2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e 
//informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

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
