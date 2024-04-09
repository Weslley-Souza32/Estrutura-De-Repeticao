﻿/*
 * Problema "validacao_de_nota" (adaptado de URI 1117)
    Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a
    média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao
    intervalo [0,10]). Cada nota deve ser validada separadamente.
    Exemplo 1:
        Digite a primeira nota: 3.5
        Digite a segunda nota: 10.0
        MEDIA = 6.75Exemplo 2:
    Digite a primeira nota: -3.5
    Valor invalido! Tente novamente: 3.5
    Digite a segunda nota: 11.0
    Valor invalido! Tente novamente: 10.5
    Valor invalido! Tente novamente: 10.0
    MEDIA = 6.75
 */

double nota1, nota2, media;

Console.WriteLine ("Digite a primeira nota:");
nota1 = double.Parse (Console.ReadLine ());

while (nota1 < 0 || nota1 > 10)
{
    Console.WriteLine ("Valor invalido! Tente novamente:");
    nota1 = double.Parse (Console.ReadLine ());
}

Console.WriteLine ("Digite a segunda nota:");
nota2 = double.Parse (Console.ReadLine ());

while (nota2 < 0 || nota2 > 10)
{
    Console.WriteLine ("Valor invalido! Tente novamente:");
    nota2 = double.Parse (Console.ReadLine ());
}

 media = (nota1 + nota2) / 2;
Console.WriteLine ($"MEDIA = {media.ToString ("F2")}");
