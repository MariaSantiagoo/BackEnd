//perguntar ao usuario quantas letras tem seu nome
//depois vamos pedir letra a letra de seu nome
// ao final, vamos exibir o nome do usuario completo

int qtdLetras = 0;


Console.WriteLine("Olá, quantas letras tem o seu nome?:P");
qtdLetras = int.Parse(Console.ReadLine());
string nome ="";

 for (int i = 1; i <= qtdLetras; i++)
 {
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome = nome + Console.ReadLine();
 }

Console.WriteLine($"Seu nome é: {nome}");


