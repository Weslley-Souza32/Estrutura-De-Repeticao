/*
 * Problema "crescente" (adaptado de URI 1113)
    Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y uma
    mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente. O
    programa deve finalizar quando forem digitados dois valores iguais.
    Exemplo:
        Digite dois numeros:
        5
        4
    DECRESCENTE!
        Digite outros dois numeros:
        3
        8
    CRESCENTE!
        Digite outros dois numeros:
        2
        2
 */
int num1, num2;

do
{
    Console.WriteLine ("Digite dois numeros:");
    num1 = int.Parse (Console.ReadLine ());
    num2 = int.Parse (Console.ReadLine ());

    if (num1 < num2)
    {
        Console.WriteLine ("CRESCENTE!");
    }
    else if (num1 > num2)
    {
        Console.WriteLine ("DECRESCENTE!");
    }
    else
    {
        Console.WriteLine ("Os numeros sao iguais. Fim do programa.");
        break;
    }
} while (num1 != num2);