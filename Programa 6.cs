Console.WriteLine("//--------------//Programa 6//--------------//");
Console.WriteLine("//-------//Buscador de tesoros//--------//");
Console.WriteLine("Dado la siguiente matriz de 10x10 averiguar las coordenadas donde se encuentran los 3 tesoros escondidos:\n");

// Matriz visible para el jugador
string[,] tabla = new string[10, 10];

// Matriz secreta con los tesoros
string[,] tablacontesoros = new string[10, 10];

// Inicializar ambas matrices
for (int f = 0; f < 10; f++)
{
    for (int c = 0; c < 10; c++)
    {
        tabla[f, c] = "-";
        tablacontesoros[f, c] = "-";
    }
}

// Mostrar matriz inicial
for (int f = 0; f < tabla.GetLength(0); f++)
{
    for (int c = 0; c < tabla.GetLength(1); c++)
    {
        Console.Write(tabla[f, c] + " ");
    }
    Console.WriteLine();
}

// Generar los 3 tesoros sin repetir coordenadas
Random tesoro = new Random();
int generados = 0;

while (generados < 3)
{
    int fila = tesoro.Next(0, 10);
    int columna = tesoro.Next(0, 10);

    if (tablacontesoros[fila, columna] != "X")
    {
        tablacontesoros[fila, columna] = "X";
        generados++;
    }
}


int intentos = 5;
int tesorosDescubiertos = 0;

while (intentos > 0 && tesorosDescubiertos < 3)
{
    int CY;
    int FX;

    // Leemos las columnas
    while (true)
    {
        Console.Write("\nInserte la coordenada en Y (Columna 0-9): ");

        try
        {
            CY = int.Parse(Console.ReadLine());

            if (CY >= 0 && CY <= 9)
                break;

            Console.WriteLine("La columna debe estar entre 0 y 9.");
        }
        catch
        {
            Console.WriteLine("Debe ingresar un número válido.");
        }
    }

    // Leemos las filas
    while (true)
    {
        Console.Write("Inserte la coordenada en X (Fila 0-9): ");

        try
        {
            FX = int.Parse(Console.ReadLine());

            if (FX >= 0 && FX <= 9)
                break;

            Console.WriteLine("La fila debe estar entre 0 y 9.");
        }
        catch
        {
            Console.WriteLine("Debe ingresar un número válido.");
        }
    }

    Console.WriteLine();

    if (tablacontesoros[FX, CY] == "X")
    {
        // Evitar encontrar el mismo tesoro dos veces
        if (tabla[FX, CY] == "X")
        {
            Console.WriteLine("Ese tesoro ya fue encontrado.");
        }
        else
        {
            tabla[FX, CY] = "X";
            tesorosDescubiertos++;

            Console.WriteLine($"¡Felicidades! Encontraste {tesorosDescubiertos} de los 3 tesoros.");
            Console.WriteLine("Tus intentos fueron reiniciados.");

            intentos = 5;

            if (tesorosDescubiertos == 3)
            {
                Console.WriteLine("\n¡¡GANASSSSSSSSSSSTEEEEEEEEEEEEEE!!");
            }
        }
    }
    else
    {
        intentos--;

        Console.WriteLine("Ups, parece que te equivocaste.");

        if (intentos > 0)
        {
            Console.WriteLine("Intentos restantes: " + intentos);
        }
        else
        {
            Console.WriteLine("Lo sentimos, te quedaste sin intentos :(");

            Console.WriteLine("\nLa matriz era:\n");

            for (int f = 0; f < tablacontesoros.GetLength(0); f++)
            {
                for (int c = 0; c < tablacontesoros.GetLength(1); c++)
                {
                    Console.Write(tablacontesoros[f, c] + " ");
                }
                Console.WriteLine();
            }

            break;
        }
    }

    Console.WriteLine("\nLa matriz quedaría así:\n");

    for (int f = 0; f < tabla.GetLength(0); f++)
    {
        for (int c = 0; c < tabla.GetLength(1); c++)
        {
            Console.Write(tabla[f, c] + " ");
        }
        Console.WriteLine();
    }
}
