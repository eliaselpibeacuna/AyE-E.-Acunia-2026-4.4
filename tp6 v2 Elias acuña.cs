// See https://aka.ms/new-console-template for more information
Console.WriteLine("Inserte un numero del 1 al 5 para ejecutar una funcion correspondiente al tp3, donde:");
Console.WriteLine("1 = Numero positivo?");
Console.WriteLine("2 = Mayor de edad?");
Console.WriteLine("3 = Contraseña secreta");
Console.WriteLine("4 = Par o Impar?");
Console.WriteLine("5 = Entrada gratis?");
Console.WriteLine("0 = cierre programa");
bool seguimos = true;
int escribir;
while (seguimos == true)
{
    Console.WriteLine(" ");
    Console.WriteLine("Inserte un numero para ejecutar un ejercicio");
    escribir = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(" ");
    switch (escribir)
    {
        case 1:

            Console.WriteLine("Ingrese un número para identificar si es positivo o negativo");
            Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));
            break;
        case 2:

            Console.WriteLine("Digame su edad porfavore, es para saber si podeis entrar a la discopary");
            Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));
            break;
        case 3:

            Console.WriteLine("Ingrese la contraseña secreta secretiña");
            Console.WriteLine(ejercicio3(Console.ReadLine()));
            break;
        case 4:

            Console.WriteLine("Ingrese un número para identificar si es par o impar");
            Console.WriteLine(ejercicio4(Convert.ToInt32(Console.ReadLine())));
            break;
        case 5:

            Console.WriteLine("Saludos caballero, hoy ofrecemos entradas gratis para el cine");
            Console.WriteLine("Por favor, ingrese su edad");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Usted compró palomitas?");
            String compro = Console.ReadLine();
            Console.WriteLine(ejercicio5(edad2, compro));
            break;
        case 0:

            Console.WriteLine("Cierre de progama...");
            seguimos = false;
            break;
        default:

            Console.WriteLine("El numero no se encuentra en la lista mencionada");
            break;
    }
}
//Funcion ej 1
string ejercicio1(int n)
{
    string resultado;
    if (n > 0)
    {
        resultado = ("el número es positivo");
        return resultado;

    }
    else if (n < 0)
    {

        resultado = ("el número es negativo");
        return resultado;
    }
    else
    {
        resultado = ("el número es 0");
        return resultado;
    }

}

//Funcion ej 2
string ejercicio2(int edad)
{
    string resultado2;
    if (edad >= 18)
    {
        resultado2 = ("Bienvenido a la discopary mi broda");
        return resultado2;
    }
    else
    {
        resultado2 = ("No puede entrar, retirese por favor");
        return resultado2;
    }
}

//Funcion ej 3
string ejercicio3(string contraseña)
{
    string resultado3;
    if (contraseña == "python123")
    {
        resultado3 = ("¡Contraseña correcta! Acceso concedido.");
        return resultado3;
    }
    else
    {
        resultado3 = ("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
        return resultado3;
    }
}
//Funcion ej 4
string ejercicio4(int a)
{
    string resultado4;
    if (a % 2 == 0)
    {
        resultado4 = ("El numero es par");
        return resultado4;
    }
    else
    {
        resultado4 = ("El numero es impar");
        return resultado4;
    }
}

//Funcion ej 5
string ejercicio5(int edad2, string respuesta5)
{
    string resultado5;
    if (edad2 >= 65 && respuesta5 == "si")
    {
        resultado5 = "Cumple con los requisitos, tenga su entrada gratuita";
        return resultado5;
    }
    else
    {
        resultado5 = "Usted no cumple con los requisitos para la entrada gratuita";
        return resultado5;
    }
}
