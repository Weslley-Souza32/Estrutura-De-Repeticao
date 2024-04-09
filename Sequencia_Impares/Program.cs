/*
 * Problema "sequencia_impares" (adaptado de URI 1067)
    Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X,
    se for o caso.
    Exemplo:
        Digite o valor de X: 8
        1
        3
        5
        7
 */

//Temos estas duas formas para resolver o mesmo problema

//nesta abaixo Usamos um loop for para iterar de 1 até X, incrementando de 2 em 2 para garantir que apenas números ímpares sejam impressos.

//Console.Write ("Digite o valor de X: ");
//int X = int.Parse (Console.ReadLine ());

//for (int i = 1; i <= X; i += 2)
//{
//    Console.WriteLine (i);
//}


//nesta fazer o for inteirando de 1 em 1 e fazemos uma estrutura condicional para verificar se o numero i do laço for e impar se for imprimimos somente eles
//na tela.
Console.Write ("Digite o valor de X: ");
int X = int.Parse (Console.ReadLine ());

for (int i = 1; i <= X; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine (i);
    }
}