Random random = new Random();
int numeroAleatorio = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
int palpite = 0;
int tentativas = 0;

Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
Console.WriteLine("Tente adivinhar o número que estou pensando, entre 1 e 100.");

while (palpite != numeroAleatorio)
{
    Console.WriteLine("Digite seu palpite:");
    palpite = Convert.ToInt32(Console.ReadLine());
    tentativas++;

    if (palpite < numeroAleatorio)
    {
        Console.WriteLine("Muito baixo! Tente novamente.");
    }
    else if (palpite > numeroAleatorio)
    {
        Console.WriteLine("Muito alto! Tente novamente.");
    }
    else
    {
        Console.WriteLine("Parabéns! Você adivinhou o número em " + tentativas + " tentativas.");
    }
}


Console.WriteLine("Obrigado por jogar o Jogo de Adivinhação!");
