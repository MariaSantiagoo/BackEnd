// Personalização de Garrafas - Classe Garrafa
// Crie uma classe que represente uma garrafa com pelo menos 3 propriedades e 2 métodos.
// Peça ao usuário para informar os dados para personalizar a garrafa e preencha as propriedades do objeto
// Peça também o nome do usuário e ao final exiba o nome do usuário e as informações da garrafa personalizada e a execução dos dois métodos

using ClassesEObjetos;


//======= Garrafa ============

// Console.Clear();

// Garrafa garrafaPet = new Garrafa();
// Console.WriteLine($"Olá! Digite o seu nome :D");
// String nome = Console.ReadLine();

// Console.WriteLine($"Digite a cor da sua garrafa:");
// garrafaPet.Cor = Console.ReadLine();

// Console.WriteLine($"Digite a capacidade da sua garrafa:");
// garrafaPet.Capacidade = int.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o tamanho da sua garrafa:");
// garrafaPet.Tamanho = int.Parse(Console.ReadLine());

// Console.WriteLine($"Digite o formato da sua garrafa:");
// garrafaPet.Formato = Console.ReadLine();

// Console.Clear();

// Console.WriteLine($"{nome} sua garrafa é {garrafaPet.Cor}, tem {garrafaPet.Capacidade}mls, tem {garrafaPet.Tamanho}cm e tem o formato de {garrafaPet.Formato}!");

// garrafaPet.Abrir();

// garrafaPet.Beber();

// 2) Classe Agência Bancária:

//         Explicação:
// O objeto ContaBancaria representa uma conta real.
// Quando o método Depositar for chamado, o saldo aumenta.
// Quando o método Sacar for chamado, o saldo diminui.
// No final, o programa deve mostrar o saldo atualizado.



Console.WriteLine($"==============Agencia Bancaria==============");
Console.WriteLine($"Text");
ContaBancaria Conta = new ContaBancaria();
Conta.Titular = "Maria Almeida";
Conta.Saldo = 1450.90f;

Conta.Depositar(50);
Conta.Sacar(50);


Console.Clear();
Produto Garrafa = new Produto();
Garrafa.Nome = "Tupperware";
Garrafa.Preco = 50;

Garrafa.AplicarDesconto(20);









// 3) Classe Produto com Desconto

//         Explicação:
// O objetivo é entender como usar um método que altera um atributo do objeto.
// Você passará o percentual de desconto e o método vai recalcular o preço.

