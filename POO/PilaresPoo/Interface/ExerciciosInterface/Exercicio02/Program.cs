using Exercicio02;

//criar uma lista para faturas, relatorios e contratos
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.Write($@"
Menu de opções:

1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:
");
    opcao = int.Parse(Console.ReadLine());



    // criar um switch para as opcoes do menu

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;

        case 2:
            Console.WriteLine($"Cadatrar Relatório em desenvolvimento.. :(");
            break;

        case 3:
            Console.WriteLine($"Cadatrar Contratos em desenvolvimento.. :(");
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento.. :(");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento.. :(");
            break;

        case 0:
            Console.WriteLine($"Saindo... Volte logo! :)");
            break;

        default:
            Console.WriteLine($"Opção inválida!:(");

            break;
    }

    Console.WriteLine($"Precione <enter> para continuar");
    Console.ReadLine();


} while (opcao != 0);




//funções

void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Digite os dias de atraso da fatura");
    int qtdAtraso = int.Parse(Console.ReadLine());

    Fatura fat = new Fatura(dev, empresa, valor, qtdAtraso);
    documentos.Add(fat);

    Console.WriteLine($"Fatura cadastrada com sucesso! ");
    

}

void CadastrarRelatorios()
{

}

void CadastrarContratos()
{

}

void ListarFaturas()
{
    Console.WriteLine($"Listando faturas");

    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }

    }
}

void ListarRelatorios()
{

}

void ListarContratos()
{

}



































































// Console.Clear();
// Fatura FatXuxu = new Fatura();
// documentos.Add(FatXuxu);

// Fatura FatGiu = new Fatura();
// documentos.Add(FatGiu);

// Relatorio RelXuxu = new Relatorio();
// documentos.Add(RelXuxu);

// Relatorio RelGiu = new Relatorio();
// documentos.Add(RelGiu);

// Contrato ContXuxu = new Contrato();
// documentos.Add(ContXuxu);

// Contrato ContGiu = new Contrato();
// documentos.Add(ContGiu);

// // Listar os dados da fatura

// Console.WriteLine($"===== Faturas =====");

// foreach (var fat in documentos)
// {
//     if(fat is Fatura)
//     {
//     fat.Imprimir();
//     }
// }

// Console.WriteLine($"===== Relatorios =====");
// foreach (var rel in documentos)
// {
//     if(rel is Relatorio)
//     {
//     rel.Imprimir();
//     }
// }

// Console.WriteLine($"===== Contratos =====");
// foreach (var cont in documentos)
// {
//     if (cont is Contrato)
//     {
//     cont.Imprimir();
//     }
// }