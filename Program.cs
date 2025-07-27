// Screen Sound

// Função sem retorno: void
void ExibirMensagem()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    string mensagem = "Boas Vindas ao Screen Sound";
    Console.WriteLine(mensagem);
}
void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nEscolha uma opção: ");
    string opcao = Console.ReadLine()!;

    // if (int.Parse(opcao) == 1)
    // {
    //     Console.WriteLine($"Você digitou a opção: {opcao}");
    // }
    // else if (int.Parse(opcao) == 2)
    // {
    //     Console.WriteLine($"Você digitou a opção: {opcao}");
    // }

    switch (int.Parse(opcao))
    {
        case 1:
            Console.WriteLine($"Você digitou a opção: {opcao}");
            break;
        case 2:
            Console.WriteLine($"Você digitou a opção: {opcao}");
            break;
        case 3:
            Console.WriteLine($"Você digitou a opção: {opcao}");
            break;
        case 4:
            Console.WriteLine($"Você digitou a opção: {opcao}");
            break;
        case -1:
            Console.WriteLine("Tchau Tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

ExibirMensagem();
ExibirMenu();