Console.WriteLine("Decrementando de 100 à 0: ");

for (int i = 100; i >= 0; i--) {
    Console.Write(i + "º - ");
}


Console.WriteLine(" ");
Console.WriteLine("----------");

Console.WriteLine("Decrementando de 100 à 0 e que são mult de 5: ");

for (int i = 100; i >= 0; i--)
{
    if (i % 5 == 0) {
        Console.Write(i + "º - ");
    } 
}

Console.WriteLine("  ");
Console.WriteLine("----------");


Console.WriteLine("Soma se div por 5 e soma os que não são div. por 5: ");

int divCinco = 0, nDivCinco = 0;

for (int i = 100; i >= 0; i--)
{
   
    if (i % 5 == 0)
    {
        divCinco += i;
    }
    else {
        nDivCinco += i;
    }
}

Console.WriteLine("Soma dos Divisiveis por 5: " + divCinco);
Console.WriteLine("Soma dos que não são div por 5: "+nDivCinco);
