
string mensagemDeBoasVindas = "BEM VINDO AO SCREEN SOUND";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"

█████████████████████████████████████████████████████████████████████████
█─▄▄▄▄█─▄▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄─█▄─▀█▄─▄███─▄▄▄▄█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
█▄▄▄▄─█─███▀██─▄─▄██─▄█▀██─▄█▀██─█▄▀─████▄▄▄▄─█─██─██─██─███─█▄▀─███─██─█
▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▀▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀"); 
    Console.WriteLine();
    Console.WriteLine(mensagemDeBoasVindas);
}


void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas Registradas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda  ");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\nDigite a sua opção: ");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

   switch (opcaoEscolhidaNumerica) 
    {
        case 1 : RegistrarBandas();
            break;
        case 2: MostraBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: MediaDaBanda();
            break;
        case 5:
            Console.WriteLine("\nAté mais tchau tchau");
            break;
        default: Console.WriteLine("\nOpção inválida");
            break;

    }

}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTitulo("Registrar banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA Banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesDoMenu();
}

void MostraBandasRegistradas()
{
    Console.Clear();
    ExibirTitulo("Registros das bandas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nAperte uma tecla para voltar pro menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMensagemDeBoasVindas();
    ExibirOpcoesDoMenu();
}


void ExibirTitulo(string titulo)
{
    int quantidadeDeLetra = titulo.Length;
    string traco = string.Empty.PadLeft(quantidadeDeLetra, '-');
    Console.WriteLine(traco);
    Console.WriteLine(titulo);
    Console.WriteLine(traco + "\n");
}

void AvaliarUmaBanda()
{ 
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        Console.Write($"Qual é a sua nota para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();

        
    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada! ");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();
    }

} 

void MediaDaBanda()
{
    Console.Clear();
    Console.Write("Digite o nome da banda que deseja ver a nota media: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notaDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notaDaBanda.Average()}.");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada! ");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey(true);
        Console.Clear();
        ExibirMensagemDeBoasVindas();
        ExibirOpcoesDoMenu();
    }

}

ExibirMensagemDeBoasVindas();

ExibirOpcoesDoMenu();




