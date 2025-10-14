//Fiz algumas modificações apenas para deixar as mensagens no terminal mais organizadinhas :)


using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE ESTACIONAMENTO");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Console.Clear();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("==========================================");
    Console.WriteLine("           MENU PRINCIPAL");
    Console.WriteLine("==========================================");
    Console.WriteLine();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine();
    Console.Write("Opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            Console.Clear();
            exibirMenu = false;
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("*** OPÇÃO INVÁLIDA ***");
            Console.WriteLine("Por favor, digite uma opção válida (1-4)");
            break;
    }

    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.WriteLine("==========================================");
    Console.ReadLine();
    Console.Clear();
}
Console.Clear();
Console.WriteLine("==========================================");
Console.WriteLine("    PROGRAMA ENCERRADO COM SUCESSO");
Console.WriteLine("==========================================");
