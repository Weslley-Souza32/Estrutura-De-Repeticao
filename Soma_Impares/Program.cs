/*
 * Problema "soma_impares" (adaptado de URI 1071)
    Leia 2 valores inteiros X e Y (em qualquer ordem). A seguir, calcule e mostre a soma dos números
    impares entre eles.
    Exemplo 1:
        Digite dois numeros:
        2
        9
        SOMA DOS IMPARES = 15
    Exemplo 2:
        Digite dois numeros:
        15
        10
        SOMA DOS IMPARES = 24
    Exemplo 3:
        Digite dois numeros:
        6
        -5
        SOMA DOS IMPARES = 5
 */

Console.WriteLine ("Digite dois numeros:");
int X = int.Parse (Console.ReadLine ());
int Y = int.Parse (Console.ReadLine ());

int somaImpares = 0;

// Certifique-se de que X seja o menor número
if (X > Y)
{
    int temp = X;
    X = Y;
    Y = temp;
}

for (int i = X + 1; i < Y; i++)
{
    if (i % 2 != 0)
    {
        somaImpares += i;
    }
}

Console.WriteLine ($"SOMA DOS IMPARES = {somaImpares}");