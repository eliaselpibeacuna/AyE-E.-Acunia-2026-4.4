//Tp 14
using System.ComponentModel.DataAnnotations.Schema;

Console.WriteLine("|||-----------------||TP 14||----------------|||");

//Ej 1
Console.WriteLine("");
Console.WriteLine("//------------// Ej 1 //------------//");
Console.WriteLine("Por favor ingrese 5 números: ");
int[] listadenum = new int[5];
for (int i = 0; i < listadenum.Length; i++)
{
    listadenum[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Los numeros insertados fueron:");
for (int i = 0; i < listadenum.Length; i++)
{
    Console.WriteLine(listadenum[i]);
}

//Ej 2
Console.WriteLine("");
Console.WriteLine("//------------// Ej 2 //------------//");
Console.WriteLine("Escriba el nombre de una fruta para saber si se encuentra en la lista de compras:");
string[] listadefrutas = { "manzana", "naranja", "mango", "banana", "ananá" };
string fruta;
bool encontrada = false;
fruta = Console.ReadLine();
fruta = fruta.ToLower();
for (int i = 0; i < listadefrutas.Length; i++)
{
    string frutaselec = listadefrutas[i];
    if (frutaselec == fruta)
    {
        encontrada = true;
        Console.WriteLine("La fruta " + fruta + " se encuentra dentro de la lista de compras en el indice " + i);
    }
}
if (encontrada == false)
{
    Console.WriteLine("La fruta no se encuentra en la lista");
}


//Ej 3
Console.WriteLine("");
Console.WriteLine("//------------// Ej 3 //------------//");
Console.WriteLine("Inserte que nota saco el estudiante en matemáticas para calcular el promedio de nota del aula y la suma total de las notas:");
string[] estudiante = { "Martin", "Elías", "Matías", "Leonel", "Joaquín", "Agustina", "Tomas", "Maia", "Melany", "Fausto" };
float[] nota = new float[10];
float suma = 0;
float prom;
for (int i = 0; i < nota.Length; i++)
{
    Console.Write("La nota de " + estudiante[i] + " es de: ");
    nota[i] = float.Parse(Console.ReadLine());
    suma = suma + nota[i];
}
prom = suma / 10;
Console.WriteLine("La suma de todas las notas es de " + suma + " y el promedio es de " + prom + ".");

//Ej 4
Console.WriteLine("");
Console.WriteLine("//------------// Ej 4 //------------//");
Console.WriteLine("Las temperaturas diarias son: \nTemp1 = 16°\nTemp2 = 21°\nTemp3 = 23°\nTemp4 = 11°\nTemp5 = 8°\nTemp6 = -2°");
int[] listatemp = { 16, 21, 23, 11, 8, -2 };
int maxtemp = -100;
int mintemp = 100;
for (int i = 0; i < listatemp.Length; i++)
{
    if (listatemp[i] < mintemp)
    {
        mintemp = listatemp[i];
    }
    if (listatemp[i] > maxtemp)
    {
        maxtemp = listatemp[i];
    }
}
Console.WriteLine("Siendo la tempera minima de " + mintemp + "° y la maxima de " + maxtemp + "°");


//Ej 5
Console.WriteLine("");
Console.WriteLine("//------------// Ej 5 //------------//");
Console.WriteLine("");
int[] numdesorndenados = {8,4,2,10,3,7,12,21,23,17};
int num = 0;
int aux1 = 0 ;
Console.WriteLine("A continuacion una lista de numeros desordenada para ordenarlos de forma ascendente");

for (int j = 0; j < numdesorndenados.Length;j++)
{
    num = numdesorndenados[j];
    Console.Write(num +"\n");
}
Array.Sort(numdesorndenados);

Console.WriteLine("\nLista de numeros ordenados de forma ascendente\n");

for (int j = 0; j < numdesorndenados.Length; j++)
{
    num = numdesorndenados[j];
    int numordenado = num;
    Console.Write(numordenado + "\n");

}


//Ej 6
Console.WriteLine("");
Console.WriteLine("//------------// Ej 6 //------------//");
Console.WriteLine("");
Console.WriteLine("A continuacion una lista de 15 numeros enteros, para determinar cuantos pares y impares contiene:");

int[] numeros = { 54, 26, 12, 76, 2, 3, 7, 17, 13, 33, 32, 16, 19, 47, 31 };

int pares = 0;
int impares = 0;

for (int j = 0; j < numeros.Length; j++)
{
    Console.WriteLine(numeros[j]);
}
foreach (int n in numeros)
{
    if (n % 2 == 0)
    {
        pares += 1;
    }
    else
    {
        impares += 1;
    }
}
Console.WriteLine("\nLa cantidad de pares son: "+ pares+ "\nY la cantidad de impares es de: "+impares);

