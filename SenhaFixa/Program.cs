﻿/*
 * Problema "senha_fixa" (adaptado de URI 1114)
   Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de
   senha incorreta informada, escrever a mensagem "Senha Invalida! Tente novamente:". Quando a senha
   for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo
   encerrado. Considere que a senha correta é o valor 2002.
    Exemplo:
        Digite a senha: 2312
        Senha Invalida! Tente novamente: 2010
        Senha Invalida! Tente novamente: 1022
        Senha Invalida! Tente novamente: 2002
        Acesso permitido!
 */

Console.Write("Digite a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

while (senha != 2024)
{
    Console.Write("ACESSO NEGADO! TENTE NOVAMENTE: ");
    senha = Convert.ToInt32 (Console.ReadLine ());
}
Console.WriteLine("ACESSO PERMITIDO!");