﻿/*
 * Problema "experiencias" (adaptado de URI 1094)
    Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para
    organizar os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano,
    quantas cobaias foram utilizadas no laboratório e o percentual de cada tipo de cobaia utilizada. Este
    laboratório em especial utiliza três tipos de cobaias: sapos, ratos e coelhos. Para obter estas
    informações, ela sabe exatamente o número de experimentos que foram realizados, o tipo de cobaia
    utilizada e a quantidade de cobaias utilizadas em cada experimento. Faça um programa que leia um
    valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um
    inteiro que representa a quantidade de cobaias utilizadas e uma letra ('C', 'R' ou 'S'), indicando o tipo
    de cobaia (R:Rato S:Sapo C:Coelho). Apresente o total de cobaias utilizadas, o total de cada tipo de
    cobaia utilizada e o percentual de cada uma em relação ao total de cobaias utilizadas, sendo que o
    percentual deve ser apresentado com dois dígitos após o ponto.
Exemplo:
    Quantos casos de teste serao digitados? 10
    Quantidade de cobaias: 10
    Tipo de cobaia: C
    Quantidade de cobaias: 6
    Tipo de cobaia: R
    Quantidade de cobaias: 15
    Tipo de cobaia: S
    Quantidade de cobaias: 5
    Tipo de cobaia: C
    Quantidade de cobaias: 14
    Tipo de cobaia: R
    Quantidade de cobaias: 9
    Tipo de cobaia: C
    Quantidade de cobaias: 6
    Tipo de cobaia: R
    Quantidade de cobaias: 8
    Tipo de cobaia: S
    Quantidade de cobaias: 5
    Tipo de cobaia: C
    Quantidade de cobaias: 14
    Tipo de cobaia: R
RELATORIO FINAL:
    Total: 92 cobaias
    Total de coelhos: 29
    Total de ratos: 40
    Total de sapos: 23
    Percentual de coelhos: 31.52
    Percentual de ratos: 43.48
    Percentual de sapos: 25.00
 */

int n, totalCobaias = 0, totalCoelhos = 0, totalRatos = 0, totalSapos = 0;

Console.WriteLine ("Quantos casos de teste serao digitados?");
n = int.Parse (Console.ReadLine ());

for (int i = 0; i < n; i++)
{
    Console.WriteLine ("Quantidade de cobaias:");
    int quantidade = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Tipo de cobaia:");
    char tipo = char.ToUpper (Console.ReadLine ()[0]);

    totalCobaias += quantidade;

    switch (tipo)
    {
        case 'C':
            totalCoelhos += quantidade;
            break;
        case 'R':
            totalRatos += quantidade;
            break;
        case 'S':
            totalSapos += quantidade;
            break;
        default:
            Console.WriteLine ("Tipo de cobaia inválido!");
            break;
    }
}

Console.WriteLine ("RELATORIO FINAL:");
Console.WriteLine ($"Total: {totalCobaias} cobaias");
Console.WriteLine ($"Total de coelhos: {totalCoelhos}");
Console.WriteLine ($"Total de ratos: {totalRatos}");
Console.WriteLine ($"Total de sapos: {totalSapos}");
Console.WriteLine ($"Percentual de coelhos: {((double)totalCoelhos / totalCobaias * 100).ToString ("F2")}");
Console.WriteLine ($"Percentual de ratos: {((double)totalRatos / totalCobaias * 100).ToString ("F2")}");
Console.WriteLine ($"Percentual de sapos: {((double)totalSapos / totalCobaias * 100).ToString ("F2")}");