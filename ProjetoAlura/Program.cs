// Screen Sound 

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string> {"U2", "The Beatles", "PinkFloid"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Pink Floid", new List<int>() );


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(mensagemDeBoasVindas);
}

void Menu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcao = Console.ReadLine();
    int opcaoEscolhida = int.Parse(opcao);
    
    switch (opcaoEscolhida)
    {
        case 1: RegistrarBandas(); 
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4:MediaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau");
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}
void ListarBandas()
{
    ExibirTituloDaOpcao("Lista de bandas");

    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }


    Console.WriteLine("Digite uma tecla para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    } else
    {
        Console.WriteLine($"Banda {nomeDaBanda} não encontrada, digite uma tecla para continuar");
        Console.WriteLine("Digite uma tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

}

void MediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Media da Banda");
    Console.Write("Digite o nome da banda que deseja exibir media: ");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A media é: {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"Banda {nomeDaBanda} não encontrada, digite uma tecla para continuar");
        Console.WriteLine("Digite uma tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}

ExibirMensagemDeBoasVindas();
Menu();





