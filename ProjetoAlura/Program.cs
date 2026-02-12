// Screen Sound 

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
List<string> listaDasBandas = new List<string> {"U2", "The Beathes", "PinkFloid"};

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
        case 3:
            Console.WriteLine("Você escolheu a opção" + opcao);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção" + opcao);
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
    listaDasBandas.Add(nomeDaBanda);
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

    foreach (string banda in listaDasBandas)
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

ExibirMensagemDeBoasVindas();
Menu();





