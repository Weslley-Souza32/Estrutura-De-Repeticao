﻿/*
 PARTE 2: estrutura para
    Problema "tabuada"
    Ler um número inteiro N, daí mostrar na tela a tabuada de N para 1 a 10, conforme exemplo.
    Exemplo:
    Deseja a tabuada para qual valor? 4
        4 x 1 = 4
        4 x 2 = 8
        4 x 3 = 12
        4 x 4 = 16
        4 x 5 = 20
        4 x 6 = 24
        4 x 7 = 28
        4 x 8 = 32
        4 x 9 = 36
        4 x 10 = 40
 */
int num;
Console.Write ("Deseja a tabuada para qual valor? ");
num = Convert.ToInt32 (Console.ReadLine ());

while (num != 0)
{
    for (int i = 1; i <= 10; i++)
    {
        int tab = num * i;
        Console.WriteLine ($"{num} X {i} = {tab}");
    }
    Console.Write ("\nDeseja a tabuada para qual valor? Ou Digite 0 para sair! ");
    num = Convert.ToInt32 (Console.ReadLine ());

}

Console.WriteLine ("saiu");

