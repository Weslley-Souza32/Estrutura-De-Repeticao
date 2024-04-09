/*
 * Problema "media_idades"
   Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um
   indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular
   e imprimir a idade média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez,
   mostrar a mensagem "IMPOSSIVEL CALCULAR".
    Exemplo 1:
        Digite as idades:
        31
        27
        46
        -5
        MEDIA = 34.67
    Exemplo 2:
        Digite as idades:
        -10
        IMPOSSIVEL CALCULAR
 */

int idade, soma = 0, contador = 0;


Console.WriteLine("Digite as idades:");
idade = Convert.ToInt32(Console.ReadLine());
if (idade < 0)
{
    Console.WriteLine("IMPOSSIVEL CALCULAR!");
}
else
{
    while (idade >= 0)
    {
        soma += idade;
        contador++;
        idade = Convert.ToInt32(Console.ReadLine());
    }
    double media = (double)soma / contador;
    Console.WriteLine ($"MEDIA = {media.ToString("F2")}");
}
