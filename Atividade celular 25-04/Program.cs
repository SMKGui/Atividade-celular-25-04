// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Atividade_celular_25_04;
Celular c1 = new Celular();

Console.WriteLine($"Que cor e o celular? ");
c1.cor = Console.ReadLine();

Console.WriteLine($"Qual o modelo? ");
c1.modelo = Console.ReadLine();

Console.WriteLine($"Qual o tamanho em cm? ");
c1.tamanho = float.Parse(Console.ReadLine());

Console.WriteLine($"Esta ligado? s/n");
string resposta = Console.ReadLine();

if (resposta == "s")
{
    c1.ligado = true;
}

if (resposta == "n")
{
    Console.WriteLine($"Deseja ligar o celular? s/n");
    string respostaLigar = Console.ReadLine();

    if (respostaLigar == "s")
    {
        c1.Ligar();
        c1.ligado = true;
    }
    else
    {
        Console.WriteLine($"Fim.");
    }
}

string escolhaFuncao = "";

do
{

    if (c1.ligado == true)
    {
        Console.WriteLine($"Que funcao deseja realizar?");
        Console.WriteLine(@$"
    [1] Desligar
    [2] Fazer ligacao
    [3] Enviar mensagem
    [4] Ver propriedades
    ");
        escolhaFuncao = Console.ReadLine();

        switch (escolhaFuncao)
        {
            case "1":
                c1.Desligar();
                break;

            case "2":
                c1.Call();
                break;

            case "3":
                c1.Mensagem();
                break;
            case "4":
                Console.WriteLine(@$"
                Cor: {c1.cor}
                Modelo: {c1.modelo}
                Tamanho: {c1.tamanho}cm
                ");
                
                break;
            default:
                Console.WriteLine($"Opcao invalida!");
                break;
        }

    }
} while (escolhaFuncao != "1" && escolhaFuncao != "2" && escolhaFuncao != "3" && escolhaFuncao != "4");