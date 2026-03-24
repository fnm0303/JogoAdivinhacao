using System.Security.Cryptography; //informando que usará essa biblioteca qdo o código for compilado

/*
v1
Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (entrada de dados)
    O usuário digita número inteiro
Processamento
    O sistema compara o número digitado com um número inteiro aleatório
OutPut (saída de dados)
    O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do chute.
*/

bool jogoDeveContinuar = true;

do
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Escolha o nível de dificuldade:");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas)");
    Console.WriteLine("2 - Médio (5 tentativas)");
    Console.WriteLine("3 - Difícil (3 tentativas)");
    Console.WriteLine("---------------------------------");

    Console.Write("Digite sua escolha: ");
    string dificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio;
    int tentativasMaximas;

    switch (dificuldadeEscolhida)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break;

        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Por favor, selecione uma dificuldade válida!");
            Console.Write("Digite Enter para continuar...");
            Console.ReadLine();
            continue; //para voltar ao início do loop no caso o do while
    }

    int[] numerosDigitados = new int[tentativasMaximas];
    int contadorNrosDigitados = 0;

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Jogo de Adivinhação");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("----------------------------------");

        Console.Write("Digite um número: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());
        // poderia declarar direto int nroAleatorio = Convert.ToInt32(Console.ReadLine());

        bool numeroEstaRepetido = false;

        for (int indiceAtual = 0; indiceAtual < numerosDigitados.Length; indiceAtual++)
        {
            if (numerosDigitados[indiceAtual] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Você já digitou esse número, tente novamente.");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite Enter para continuar...");
            Console.ReadLine();

            tentativaAtual--; //para o jogador não perder uma tentativa se caso digitar o mesmo número que já tentou
            continue;
        }

        if (contadorNrosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNrosDigitados] = numeroDigitado;
            contadorNrosDigitados++;
        }
        else
        {
            numerosDigitados = new int[tentativasMaximas];
            contadorNrosDigitados = 0;

            numerosDigitados[contadorNrosDigitados] = numeroDigitado;
            contadorNrosDigitados++;
        }
        //o if else acima é para garantir que nunca será tentado acessar um ponto no array que não existe

        if (numeroAleatorio == numeroDigitado) //poderia converter direto nessa linha a string para int
        {
            Console.WriteLine("Parabéns! Você acertou! O número era " + numeroAleatorio);
            break;
        }

        else if (numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("O número digitado foi maior que o número secreto!");
        }

        else
        {
            Console.WriteLine("O número digitado foi menor que o número secreto!");
        }

        Console.ReadLine(); //para mostrar as dicas a cada tentativa
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (s/n)");
    string opcaoContinuar = Console.ReadLine().ToUpper(); //transforma qualquer letra digitada em maiuscula

    if (opcaoContinuar != "S")
    {
        jogoDeveContinuar = false;
    }
}
while (jogoDeveContinuar);

Console.ReadLine();


