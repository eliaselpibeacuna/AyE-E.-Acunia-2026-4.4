
Console.WriteLine("//--------Recursiva----------//");

int n;
n = 0;
Console.WriteLine(recursiva(n));
int recursiva(int n)
{
    if (n == 10)
    {
        return n;

    }
    else
    {
        Console.WriteLine(n);
        return recursiva(n += 1);
    }
}
//Ejercicio 1 tp4
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 1----------//");
Console.WriteLine("");

Console.WriteLine("A continuacion una lista de numeros del 1 al 10");
n = 1;
Console.WriteLine(recursiva(n));
int recursiva1(int n)
{
    if (n == 10)
    {
        return n;

    }
    else
    {
        Console.WriteLine(n);
        return recursiva1(n += 1);
    }
}
//Ejercicio 2 tp4
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 2----------//");
Console.WriteLine("");

Console.WriteLine("'¡Hola mundo!' pero 5 veces");
n = 1;
Console.WriteLine(recursiva2(n));
String recursiva2(int n)
{
    if (n == 5)
    {
        return "¡Hola mundo!";

    }
    else
    {
        Console.WriteLine("¡Hola mundo!");
        return recursiva2(n += 1);
    }
}
//Ejercicio 3 tp4
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 3----------//");
Console.WriteLine("");
Console.WriteLine("Numeros pares del 2 al 20");
n = 2;
Console.WriteLine(recursiva3(n));
int recursiva3(int n)
{
    if (n == 20)
    {
        return n;

    }
    else
    {
        Console.WriteLine(n);
        return recursiva3(n += 2);
    }
}


//Ejercicio 4 tp4
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 4----------//");
Console.WriteLine("");
Console.WriteLine("Tabla del 7:");
n = 0;
Console.WriteLine(recursiva4(n));
int recursiva4(int n)
{
    if (n == 10)
    {
        return n * 7;

    }
    else
    {
        Console.WriteLine(n * 7);
        return recursiva4(n + 1);
    }
}

//Ejercicio 5 tp4
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 5----------//");
Console.WriteLine("");
n = 1;
int acum = 0;
Console.WriteLine("A continuacion se presentan numeros del 1 al 5 que se suman entre si , es decir (1+2+3+4+5)");
Console.WriteLine(recursiva5(n));
int recursiva5(int n)
{
    acum = acum + n;
    if (n == 5)
    {
        return acum;

    }
    else
    {
        Console.WriteLine(acum);
        return recursiva5(n += 1);
    }
}
//Ejercicio 1 tp5
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 6----------//");
Console.WriteLine("");
Console.WriteLine("Ingrese la contraseña secreta (esta vez si que no es Quesito777)");
String Contraseña = Console.ReadLine();

Console.WriteLine(recursiva6(Contraseña));
string recursiva6(string Contraseña)
{
    if (Contraseña == "Elmascrack999")
    {
        return "¡¡Adivinaste la contraseña!!";

    }
    else
    {
        Console.WriteLine("Contraseña incorrecta, porfavor intentelo de nuevo:");
        return recursiva6(Contraseña = Console.ReadLine());
    }
}

//Ejercicio 2 tp5
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 7----------//");
Console.WriteLine("");
Console.WriteLine("A Continuacion una cuenta regresiva de 5 a 1 antes del despegue");
n = 5;
Console.WriteLine(recursiva7(n));
int recursiva7(int n)
{
    if (n == 1)
    {
        return n;

    }
    else
    {
        Console.WriteLine(n);
        return recursiva7(n -= 1);
    }
}
Console.WriteLine("¿Listo para despegar?");
Console.WriteLine("¡¡Despegue!!");
//Ejercicio 3 tp5
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 8----------//");
Console.WriteLine("");
Console.WriteLine("Adivina el numero secreto");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(recursiva8(n));
string recursiva8(int n)
{
    if (n == 47)
    {
        return "¡¡Adivinaste!!";

    }
    else
    {
        Console.WriteLine("Numero erroneo, intenta de nuevo");
        return recursiva8(n = Convert.ToInt32(Console.ReadLine()));
    }
}

//Ejercicio 4 tp5
Console.WriteLine("");
Console.WriteLine("//--------Ejercicio 9----------//");
Console.WriteLine("");
Console.WriteLine("Escriba numeros para sumarlos, si quiere terminar la suma ingrese 0");
int suma = 0;
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(recursiva9(n));
string recursiva9(int n)
{
    if (n == 0)
    {
        return "La suma total es de " + suma;

    }
    else
    {
        suma += n;
        Console.WriteLine("Ingrese otro numero:");
        return recursiva9(n = Convert.ToInt32(Console.ReadLine()));
    }
}