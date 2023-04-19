int Primeiro, Segundo, Maior;

Console.Clear();

Console.Write("Insira o Primeiro Número...: ");
Primeiro = Convert.ToInt32(Console.ReadLine());


Console.Write("Insira o Segundo Número....: ");
Segundo = Convert.ToInt32(Console.ReadLine());

if (Primeiro > Segundo)
{
    Maior = Primeiro;
}

else
{
    Maior = Segundo;
}
Console.WriteLine();

Console.WriteLine($"O Maior número é...........: {Maior}");