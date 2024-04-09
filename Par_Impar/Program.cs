/*
 * Problema "par_impar" (adaptado de URI 1074)
    Leia um valor inteiro N. Este valor será a quantidade de números inteiros que serão lidos em seguida.
    Para cada valor lido, mostre uma mensagem dizendo se este valor lido é PAR ou IMPAR, e também
    se é POSITIVO ou NEGATIVO. No caso do valor ser igual a zero (0), seu programa deverá imprimir
    apenas NULO.
    Exemplo:
        Quantos numeros voce vai digitar? 4
       Digite um numero: -5
        IMPAR NEGATIVO
       Digite um numero: 0
        NULO
       Digite um numero: 3
        IMPAR POSITIVO
       Digite um numero: -4
        PAR NEGATIVO
 */

Console.Write("Quantos números você vai digitar? ");
int numX = int.Parse(Console.ReadLine());

for (int i = 0; i < numX; i++)
{
    Console.Write("Digite um número: ");
    int numY  = int.Parse(Console.ReadLine());

    if (numY % 2 == 0 && numY > 0)
    {
        Console.WriteLine("PAR POSITIVO");
    }
    else if (numY % 2 == 0 && numY < 0)
    {
        Console.WriteLine ("PAR NEGATIVO");
    }
    else if(numY % 2 != 0 &&  numY > 0)
    {
        Console.WriteLine ("IMPAR POSITIVO");
    }
    else if (numY % 2 != 0 && numY < 0)
    {
        Console.WriteLine ("IMPAR NEGATIVO");
    }
    else
    {
        Console.WriteLine ("NULO");
    }
}