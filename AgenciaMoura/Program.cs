string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes;
int opcao;



do
{
    Console.Clear();
    Console.WriteLine($"===============================================");
    Console.WriteLine($"");
    Console.WriteLine($"============Sistema Bancário Simples===========");
    Console.WriteLine($"");
    Console.WriteLine($"===============================================");
    Console.WriteLine($"");
    Console.WriteLine($"");



    Console.WriteLine($"    1.Cadastrar cliente");
    Console.WriteLine($"    2.Depositar");
    Console.WriteLine($"    3.Sacar");
    Console.WriteLine($"    4.Transferir");
    Console.WriteLine($"    5.Listar Clientes");
    Console.WriteLine($"    0.Sair");
    Console.WriteLine($"");
    Console.WriteLine($"Escolha uma opção:");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine($"Pressione <Enter> para continuar");
    Console.ReadLine();

    switch (opcao)
    {
        case 0:

            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarCliente();
            break;

        default:
            Console.WriteLine($"Ops, infelizmente esta opção está inválida:(");

            break;
    }



} while (opcao != 0);


void CadastrarCliente()
{
    Console.WriteLine($"Função cadastrar cliente em desenvolvimento");

    if (totalClientes >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido:(");
        return;
    }

    Console.WriteLine($"Digite o nome do cliente");
    nomes[totalClientes] = Console.ReadLine();

    Console.WriteLine($"Digite o saldo de {saldos[totalClientes]}");
    saldos[totalClientes] = 0f;
    totalClientes++;
    Console.WriteLine($"Ebaa! Cliente cadastrado com sucesso!:D");
    

}

void Depositar()
{
    Console.WriteLine($"Função depositar em desenvolvimento");

}

void Sacar()
{
    Console.WriteLine($"Função sacar em desenvolvimento");

}

void Transferir()
{
    Console.WriteLine($"Função transferir em desenvolvimento");

}

void ListarCliente()
{
for (var i = 0; i < totalClientes; i++)
{
    Console.WriteLine($"{i} - {nomes{i}} | {saldos{i}}");
    
}

}
