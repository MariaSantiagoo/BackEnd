string[] nomes = new string[3];
int[] idades = new int[4];
int totalAlunos = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"==== Aplicativo Sala de Aula ====");
    Console.WriteLine($"    1. Listar Alunos");
    Console.WriteLine($"    2. Cadastrar Alunos");
    Console.WriteLine($"    0. Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            break;
        case 1:

            ListarAluno();
            break;
        case 2:

            CadastrarAluno();
            break;
        default:
            break;
    }


    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void ListarAluno()

{
    Console.WriteLine("==== Listagem de Alunos ====");
    //exibir o nome dos alunos  
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Nomes: {nomes[i]}, {idades[i]} anos");
    }
}

void CadastrarAluno()
{
    Console.WriteLine("==== Cadastro de Alunos ====");

    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido:(");

    }

    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine($"Digite a idade de {nomes[totalAlunos]}");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
Console.WriteLine($"Aluno Cadastrado com sucesso!:D");

}


