//TP !3
Console.WriteLine("//-------------Tp 13-------------//");


//Ejercicio 1
Console.WriteLine("");
Console.WriteLine("//==========// Ej 1 //==========//");
Console.WriteLine("");
Console.WriteLine("Inserte 10 palabras para identificar la palabra mas larga");
string[] listadepalabras;
string palabramaslarga = "";
int intentos = 10;
listadepalabras = new string[10];
for (int j = 0; j < listadepalabras.Length; j++)
{
    intentos -= 1;
    Console.WriteLine("Inserte su palabra.");
    listadepalabras[j] = Console.ReadLine();
    if (listadepalabras[j].Length >= palabramaslarga.Length)
    {
        palabramaslarga = listadepalabras[j];
    }
    if (intentos == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("Usted se a quedado sin intentos y la palabra mas larga que escribió fue " + palabramaslarga + " con un total de " + palabramaslarga.Length + " letras.");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("La palabra mas larga escrita es " + palabramaslarga + " con un total de " + palabramaslarga.Length + " letras.");
        Console.WriteLine("Le quedan " + intentos + " intentos.");
        Console.WriteLine("");
    }
}


//Ejercicio 2
Console.WriteLine("");
Console.WriteLine("//==========// Ej 2 //==========//");
Console.WriteLine("");
string vocales = "aeiouAEIOU";
int cont = 0;
for (int w = 0; w < listadepalabras.Length; w++)
{
    for(int p = 0; p < listadepalabras[w].Length; p++)
    {
        for (int z = 0; z < vocales.Length; z++)
        {
            if (listadepalabras[w][p] == vocales[z])
            {
                cont = cont + 1;
            }
        }
    }
}
Console.WriteLine("La cantidad de vocales de las palabras insertadas anteriormente es de "+ cont+ ".");


//Ejercicio 3
Console.WriteLine("");
Console.WriteLine("//==========// Ej 3 //==========//");
Console.WriteLine("");
Console.WriteLine("Inserte números y luego inserte el numero por el cual quiere que se multipliquen");
Console.WriteLine("Inserte 5 números");
int[]listadenum = new int[10];
for (int k = 0; k < listadenum.Length; k++)
{
    Console.WriteLine("Inserte el "+(k+1)+"° numero:" );
    listadenum[k] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("Ahora inserte el factor por el cual se multiplicaran todos los números:");
int factor = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("La lista quedaría asi; ");
for (int y = 0; y < listadenum.Length; y++)
{
    int resultado = listadenum[y] * factor;
    Console.WriteLine(listadenum[y] + " x " + factor + " = " + resultado);
}