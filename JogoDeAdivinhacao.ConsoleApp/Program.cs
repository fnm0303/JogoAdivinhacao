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

Console.WriteLine("---------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("---------------------");

Console.WriteLine();
Console.Write("Digite um número: ");
string strNumeroDigitado = Console.ReadLine();

Console.WriteLine("O número digitado foi: " + strNumeroDigitado);

Console.ReadLine();
