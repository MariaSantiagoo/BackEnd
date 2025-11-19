// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI

using Exercicio01;
Console.Clear();
Console.WriteLine($"--Bem vindo ao programa de geometria--");
Console.WriteLine($"");

Console.WriteLine($"Vamos calcular a área do retângulo:");

Console.Write($"Informe a altura: "); 
float Altura = float.Parse(Console.ReadLine());
Console.Write($"Informe a largura: ");
float Largura = float.Parse(Console.ReadLine());

Retangulo Giu = new Retangulo(Largura, Altura);
Giu.CalcularArea();

Console.WriteLine($"Agora, vamos calcular o raio do circulo:");
Console.Write($"Informe o raio: "); 
double Raio = double.Parse(Console.ReadLine());

Circulo Mari = new Circulo(Raio);
Mari.CalcularArea();
