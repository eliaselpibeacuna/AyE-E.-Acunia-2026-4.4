// EJERCICIO 1: Numero Primo
Console.WriteLine("");
Console.WriteLine("Ingrese un numero para identificar si es primo o no:");
int num = Convert.ToInt32(Console.ReadLine());

bool esPrimo = true;

if (num <= 1) esPrimo = false;

for (int i = 2; i < num; i++)
{
    if (num % i == 0)
    {
        esPrimo = false;
        break;
    }
}

Console.WriteLine(esPrimo ? "Es primo" : "No es primo ");


// EJERCICIO 2: Factorial
Console.WriteLine("");
Console.WriteLine("Ingrese un numero no negativo para calcular su factorial:");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    Console.WriteLine("No se puede calcular factorial de negativos.");
}
else
{
    long fact = 1;

    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }

    Console.WriteLine("Factorial: " + fact);
}


//EJERCICIO 3: Fibonacci
Console.WriteLine("");
Console.WriteLine("Ingrese cantidad de terminos para dar con su secuencia Fibonacci:");
int f = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1;

Console.Write("Secuencia Fibonacci: ");

for (int i = 0; i < f; i++)
{
    Console.Write(a + " ");

    int temp = a + b;
    a = b;
    b = temp;
}

Console.WriteLine();


//EJERCICIO 4: Menu con switch
int opcion;

do
{
    Console.WriteLine("--- MENU ---");
    Console.WriteLine("1. Saludar");
    Console.WriteLine("2. Despedirse");
    Console.WriteLine("3. Terminar programa");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("hola, sea bienvenido papu");
            break;

        case 2:
            Console.WriteLine("chau");
            break;

        case 3:
            Console.WriteLine("Cerrando programa...");
            break;

        default:
            Console.WriteLine("Usted ah insertado un termino invalido.");
            break;
    }

} while (opcion != 3);