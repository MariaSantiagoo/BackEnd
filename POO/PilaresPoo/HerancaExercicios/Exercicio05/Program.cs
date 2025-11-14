// Exercício 5 – Sistema bancário
// Crie uma classe Conta com as propriedades Numero e Saldo, e métodos Depositar() e Sacar().
// Crie uma classe ContaPoupanca que herde de Conta e possua um método CalcularRendimento() que aumente o saldo em 2%.
// Na Program, crie uma ContaPoupanca, deposite um valor e aplique o rendimento, exibindo o saldo antes e depois.


using Exercicio05;

ContaPoupança Mari = new ContaPoupança();
Mari.Numero = 1234;
Mari.Depositar();
Mari.CalcularRendimento();


