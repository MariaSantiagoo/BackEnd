using PrimeiraClasse;

Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


//Pessoa edu = new Pessoa();
//edu.Nome = "Eduardo Mendes";
//edu.Idade = 43;
//edu.Altura = 166;

//edu.Falar();
//edu.Dormir();


// Garrafa Tupperware = new Garrafa();
// Tupperware.Cor = "Rosa";
// Tupperware.Capacidade = 500;
// Tupperware.Tamanho = 27;
// Tupperware.Formato = "Arredondada";

// Tupperware.Abrir();
// Tupperware.Beber();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Rosa Claro";
// Stanley.Capacidade = 500;
// Stanley.Formato = "Cilíndrico";
// Stanley.Tamanho = 20;
// Console.WriteLine($"Abrindo a garrafa Stanley: ");
// Stanley.Abrir();

// Console.WriteLine($"Bebendo água da garrafa Stanley: ");
// Stanley.Beber();

Console.Clear();
Pessoa Mari = new Pessoa();
Mari.Nome = "Maria Santiago";
Mari.Envelhecer();//1
Mari.Altura = 160;

Console.WriteLine($"{Mari.Nome} tem {Mari.Idade} anos");
Mari.Envelhecer(10);
Console.WriteLine($"{Mari.Nome} tem {Mari.Idade} anos");




