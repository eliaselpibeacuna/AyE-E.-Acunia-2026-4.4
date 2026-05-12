
//ejercicio 1
Console.WriteLine("//-------Ejercicio 1----------//");
Console.WriteLine("");
try
{
    Console.WriteLine("¿Cuantas horas trabaja a la semana?");
    int horasemanal;
    int horaextra = 0;
    horasemanal = Convert.ToInt32(Console.ReadLine());
    int nuevosalario;
    int hora = 0;
    int salariosemanal = (funcion1(horasemanal));
    int funcion1(int horasemanal)
    {
        if (horasemanal <= 40)
        {
            for (int h = 1; h <= horasemanal; h++)
            {
                hora = hora + 16;
            }
            return hora;
        }
        else
        {
            for (int h = 1; h <= 40; h++)
            {
                hora += 16;
            }
            for (int i = 41; i <= horasemanal; i++)
            {
                horaextra += 20;
            }
            nuevosalario = hora + horaextra;
            return nuevosalario;
        }
    }
    if (horaextra == 0)
    {
        Console.WriteLine("Su salario es de " + salariosemanal + "$");
    }
    else
    {
        Console.WriteLine("Usted hizo " + (horasemanal - 40) + " horas extras, asi que su salario es de " + salariosemanal + "$");
    }
}
catch (SystemException)
{
    Console.WriteLine("//ERROR1006: Por favor, inserte UNICAMENTE numeros enteros");
}

//ejercicio 2
Console.WriteLine("");
Console.WriteLine("//-------Ejercicio 2----------//");
Console.WriteLine("");

try
{
    void funcion2()
    {
        Console.WriteLine("Ingrese numeros, el programa se detendra hasta que ingrese 0 y devolvera la suma de todos los numeros:");
        int num = 1;
        int acum = 0;
        while (num != 0)
        {
            num = Convert.ToInt32(Console.ReadLine());
            acum += num;
            if (num == 0)
            {
                Console.WriteLine("La suma de todos los numeros insertados es de " + acum);
                break;
            }
        }

        return;
    }
    funcion2();
}
catch (SystemException)
{
    Console.WriteLine("//ERROR666: Por favor, inserte UNICAMENTE numeros enteros, no otro tipo de caracter");
}


//ejercicio 3
Console.WriteLine("");
Console.WriteLine("//-------Ejercicio 3----------//");
Console.WriteLine("");

try
{
    void Funcion3()
    {
        string vocal = "aeiouAEIOU";
        int acum = 0;
        Console.WriteLine("Ingrese una palabra para contar la cantidad de vocales que contiene;");
        string palabra = Console.ReadLine();
        for (int i = 0; i < palabra.Length; i++)
        {
            for (int h = 0; h < vocal.Length; h++)
            {
                if (palabra[i] == vocal[h])
                {
                    acum = acum + 1;
                }
            }
        }
        Console.WriteLine("La cantidad de vocales que tiene la palabra insertada es de " + acum);
        return;
    }
    Funcion3();
}
catch (SystemException)
{
    Console.WriteLine("//ERROR777:Usted ingreso algo que no corresponde a una letra");
}



//ejercicio 4
Console.WriteLine("");
Console.WriteLine("//-------Ejercicio 4----------//");
Console.WriteLine("");

try
{
    void Funcion4()
    {
        Console.WriteLine("Insertar una palabra para saber si es un palindromo o no");
        bool seguimos = true;
        while (seguimos)
        {
            Console.WriteLine("Inserte una palabra");
            String palabra = Console.ReadLine();
            palabra = palabra.ToLower();
            string palabrainvertida = "";
            int letras = palabra.Length;
            for (int j = letras; j > 0; j--)
            {
                Char PI = palabra[j - 1];
                palabrainvertida = palabrainvertida + PI;
            }
            Console.WriteLine("La palabra invertida quedaria como: " + palabrainvertida);
            if (palabrainvertida == palabra)
            {
                Console.WriteLine("La palabra " + palabra + " es un palindromo.");
                seguimos = false;
            }
            else
            {
                Console.WriteLine("La palabra " + palabra + " NO es un palindromo");
            }

        }
        return;
    }
    Funcion4();
}
catch (SystemException)
{
    Console.WriteLine("//ERROR6767: Caracter invalido.");
}
