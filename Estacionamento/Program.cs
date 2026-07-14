using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n");

decimal precoInicial = LerDecimal("Digite o preço inicial:");
decimal precoPorHora = LerDecimal("Agora digite o preço por hora:");

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

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
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou");

// Lê um valor decimal do console, repetindo a pergunta até receber uma entrada válida e não negativa
static decimal LerDecimal(string mensagem)
{
    decimal valor;
    Console.WriteLine(mensagem);

    while (!decimal.TryParse(Console.ReadLine(), out valor) || valor < 0)
    {
        Console.WriteLine("Valor inválido. Por favor, digite um número válido e não negativo:");
    }

    return valor;
}
