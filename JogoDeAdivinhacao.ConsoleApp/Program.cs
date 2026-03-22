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

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21); //número mínimo, número máximo + 1
bool jogoDeveContinuar = true;

do
{
    Console.Clear();
    Console.WriteLine("---------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("---------------------");

    Console.WriteLine();
    Console.Write("Digite um número: ");
    string strNumeroDigitado = Console.ReadLine();

    int numeroDigitado = Convert.ToInt32(strNumeroDigitado);
    // poderia declarar direto int nroAleatorio = Convert.ToInt32(Console.ReadLine());
    if (numeroAleatorio == numeroDigitado) //poderia converter direto nessa linha a string para int
    {
        Console.WriteLine("Parabéns! Você acertou! O número era " + numeroAleatorio);
        break;
    }

    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("O número digitado fo maior que o número secreto!");
    }

    else
    {
        Console.WriteLine("O número digitado foi menor que o número secreto!");
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


