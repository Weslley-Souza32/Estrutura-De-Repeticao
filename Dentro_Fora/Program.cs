/*
 * Problema "dentro_fora" (adaptado de URI 1072)
    Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
    conforme exemplo
    Exemplo:
        Quantos numeros voce vai digitar? 5
        Digite um numero: 14
        Digite um numero: 35
        Digite um numero: 10
        Digite um numero: 131
        Digite um numero: 8
        2 DENTRO
        3 FORA
 */

Console.Write("Quantos numeros você vai digitar? ");
int quantidadeDeNumeros = Convert.ToInt32(Console.ReadLine());

int totalDentro = 0, totalFora = 0;

for (int i = 0; i < quantidadeDeNumeros; i++)
{
    Console.Write ("Digite um número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 10 && num <= 20)
    {
        totalDentro++;
    }
    else
    {
        totalFora++;
    }
}
Console.WriteLine ($"{totalDentro} DENTRO");
Console.WriteLine ($"{totalFora} FORA");