// //----------TP 15---------//
//Ej 1
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
Console.WriteLine("//----------//EJ 1//----------//");
Console.WriteLine("");
Console.WriteLine("A continuacion una matriz de 3 cuadrada con numeros del 1 al 9\n");
int[,] m1 = { {1, 2, 3},
             {4, 5, 6},
             {7, 8, 9}
};
//Imprimir matriz
for (int j = 0; j < m1.GetLength(0); j++)
{
    for (int k = 0; k < m1.GetLength(1); k++)
    {
        Console.Write(m1[j, k] + " ");
    }
    Console.Write("\n");
}
//Ej2

Console.WriteLine("//----------//EJ 2//----------//\n");
Console.WriteLine("A continuacion se muestra una matriz de 3 cuadrada y el resultado de sumar todos sus componentes:");
int acum = 0;
int[,] m2 = { {10, 20, 30},
              {40, 50, 60},
              {70, 80, 90}
};
for (int j = 0; j < m2.GetLength(0); j++)
{
    for (int k = 0; k < m2.GetLength(1); k++)
    {
        int num = m2[j, k];
        acum += num;
        Console.Write(m2[j, k] + " ");

    }
    Console.Write("\n");
}
Console.WriteLine("La suma total de los numeros es de " + acum);

//Ej3


    Console.WriteLine("//----------//EJ 3//----------//\n");
    Console.WriteLine("Ingrese el numero correspondiente a la cordenada de una matriz 4 cuadrada\n");
    //insertar matriz
    int[,] m3 = new int[4, 4];

    for (int j = 0; j < m3.GetLength(0); j++)
    {
        for (int k = 0; k < m3.GetLength(1); k++)
        {
            Console.WriteLine("Inserte el numero que ira en la fila " + j + " y columna " + k);
            m3[j, k] = int.Parse(Console.ReadLine());
        }
        Console.Write("\n");
    }
    Console.WriteLine("Ingrese la cordenada teniendo en cuenta que (f, c); ");
    Console.Write("Inserte la fila: ");
    int fila = int.Parse(Console.ReadLine());
    Console.Write("Inserte la columna: ");
    int columna = int.Parse(Console.ReadLine());
    Console.WriteLine("El numero que se encuentra en esa coordenada es: " + m3[fila, columna]);

//Ej4
    Console.WriteLine("//----------//EJ 4//----------//\n");
    Console.WriteLine("Ingrese el numero correspondiente a la cordenada de una matriz 4 cuadrada\n");
    int[,] m4 = new int[4, 4];
    int nummayor = int.MinValue;
    for (int j = 0; j < m4.GetLength(0); j++)
    {
        for (int k = 0; k < m4.GetLength(1); k++)
        {
            Console.WriteLine("Inserte el numero que ira en la fila " + j + " y columna " + k);
            m4[j, k] = int.Parse(Console.ReadLine());
            if (m4[j, k] > nummayor)
            {
                nummayor = m4[j, k];
            }
        }
        Console.Write("\n");
    }
    Console.WriteLine("La Matriz quedaria asi :\n");
    for (int j = 0; j < m4.GetLength(0); j++)
    {
        for (int k = 0; k < m4.GetLength(1); k++)
        {
            Console.Write(m4[j, k] + " ");
        }
        Console.Write("\n");
    }
    Console.WriteLine("Y el numero mas grande de la matriz es " + nummayor);

//Ej5
Console.WriteLine("//----------//EJ 5//----------//\n");
Console.WriteLine("A continuacion se mostrara una matriz asi como la suma de cada fila, y de cada columna:\n");
//Acumuladores de cada fila

int[,] m5 = { {7, 12, 18, 5},
              {16, 9, 4, 25},
              {2, 15, 20, 3},
              {10, 14, 22, 24}
};
Console.WriteLine("La matriz es:\n");
for (int j = 0; j < m5.GetLength(0); j++)
{
    for (int k = 0; k < m5.GetLength(1); k++)
    {
        int num = m5[j, k] ;
        Console.Write(num + " ");

    }
    Console.Write("\n");
}
Console.WriteLine("\nLa suma de cada fila es: ");
for (int j = 0; j < m5.GetLength(0); j++)
{
    int sumafila = 0;
    for (int k = 0; k < m5.GetLength(1); k++)
    {
        int num = m5[j, k];
        sumafila += num;

    }
    Console.WriteLine("Fila "+ j +" = "+ sumafila);
}
//suma de columnas
Console.WriteLine("\nY la suma de cada columna es:");
for (int k = 0; k < m5.GetLength(1); k++)
{
    int sumacolumna = 0;
    for (int j = 0; j < m5.GetLength(0); j++)
    {
        int num = m5[j, k];
        sumacolumna += num;

    }
    Console.WriteLine("Columna " + k + " = " + sumacolumna);
}


//Ej6
Console.WriteLine("//----------//EJ 6//----------//\n");
int[,] m6 =
{ 
         { 1, 2, 3, 4 },
         { 5, 6, 7, 8 },
         { 9, 10 ,11 ,12},
         { 13 ,14 ,15, 16 }
};
Console.WriteLine("Dado la siguiente matriz :\n");
for (int j = 0; j < m6.GetLength(0); j++)
{
    for (int k = 0; k < m6.GetLength(1); k++)
    {
        Console.Write(m6[j, k] + " ");
    }
    Console.Write("\n");
}

Console.WriteLine("\nEsta es su traspuesta :\n");

for (int k = 0; k < m6.GetLength(0); k++)
{
    for (int j= 0; j < m6.GetLength(1); j++)
    {
        Console.Write(m6[j, k] + " ");
    }
    Console.Write("\n");
}

//Ej7
Console.WriteLine("\n//----------//EJ 7//----------//\n");
Console.WriteLine("Dada la siguiente matriz;\n");
int cont = 0;
int[,] m7 =
{  {1, 5, 3, 5 },
   { 8, 5, 9, 2},
   { 4, 5, 6, 7}
};
for (int j = 0; j < m7.GetLength(0); j++)
{
    for (int k = 0; k < m7.GetLength(1); k++)
    {
        Console.Write(m7[j, k] + " ");
    }
    Console.Write("\n");
}
Console.WriteLine("\nIngrese un num para ver cuantas veces se repite: ");
int buscar = int.Parse(Console.ReadLine());
for (int j = 0; j < m7.GetLength(0); j++)
{
    for (int k = 0; k < m7.GetLength(1); k++)
    {
        int num = m7[j, k]; 
        if (num == buscar)
        {
            cont += 1;
        }
    }
}
if (cont == 0)
{
    Console.WriteLine("El numero "+buscar+" no se encuentra en la matriz.");
}
else if(cont == 1)
{
    Console.WriteLine("El numero " + buscar + " se encuentra una vez en la matriz.");
}
else
{
    Console.WriteLine("El numero " + buscar + " se encuentra "+cont+" veces en la matriz.");
}


//Ej8
Console.WriteLine("\n//----------//EJ 8//----------//\n");
Console.WriteLine("Dada esta matriz\n");
double acum1 = 0;
int[,] m8 =
{  {1, 2, 3, 16 },
   {17, 6, 15, 2},
   {20, 8, 13, 14},
   {6, 7, 10, 11}
};
for (int j = 0; j < m8.GetLength(0); j++)
{
    for (int k = 0; k < m8.GetLength(1); k++)
    {
        double num = m8[j, k];
        Console.Write(num + " ");
        acum1 += num;
    }
    Console.Write("\n");
}
double prom = acum1 / 16;
Console.WriteLine("\nEl promedio de todos los numeros de la matriz es de "+prom+".\n");

for (int j = 0; j < m8.GetLength(0); j++)
{
    for (int k = 0; k < m8.GetLength(1); k++)
    {
        double num = m8[j, k];
        if ( num < prom)
        {
            Console.Write(prom + " ");
        }
        else
        {
            Console.Write(num + " ");
        }
    }
    Console.Write("\n");
}


