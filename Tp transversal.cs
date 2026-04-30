//ejercicio 1
using System.Timers;

void ej1()
{

    Console.WriteLine("");
    Console.WriteLine("A continuacion una lista con los multiplos del 3 del 1 al 100");

    for (int x = 3; x < 100; x += 3)
    {
        Console.WriteLine(x);

    }
}

//ejercicio 2
void ej2()
{

    Console.WriteLine("");
    Console.WriteLine("Ingrese su edad para determinar si es mayor de edad, menor, o si tiene la edad justa:");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad > 18)
    {
        Console.WriteLine("usted es mayor de edad");
    }
    else if (edad == 18)
    {
        Console.WriteLine("Usted es mayor de edad y tiene 18");
    }
    else
    {
        Console.WriteLine("Usted es menor de edad");
    }
}

//ejercicio 3
void ej3()
{
    Console.WriteLine("");
    Console.WriteLine("Escriba una palabra");
    int cont = 0;
    string palabra = Console.ReadLine();

    for (int i = 1; i <= palabra.Length; i++)
    {
        cont = i;
    }
    Console.WriteLine("La palabra " + palabra + " tiene "+ cont +  " letras");
}

//ejercicio 4
void ej4()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese la contraseña secreta, tiene 5 intentos (en definitiva no es Abduzcan777)");
    String Contraseña = Console.ReadLine();
    int intentos = 5;
    while (Contraseña != "Abduzcan777" || intentos == 0)
    {
        intentos = intentos - 1;
        Console.WriteLine("Contraseña incorrecta, le quedan "+intentos+" intentos");
        Contraseña = Console.ReadLine();

        if( intentos == 1 )
        {
            Console.WriteLine("Se a bloqueado la pantalla durante 9999 años y se a enviado un misil a su domicilio.");
            break;
        }
    }
    if (Contraseña == "Abduzcan777")
    {
        Console.WriteLine("Contraseña correcta, Entrando...");
    }

}

//ejercicio 5
void ej5()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese 10 numeros para determinar cual es el mas alto");
    int num;
    Console.WriteLine("Ingrese el primer numero:");
    int mayor = Convert.ToInt32(Console.ReadLine());

    for (int h = 2; h <= 10; h++)
    {
        Console.WriteLine("Ingrese otro numero:");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > mayor)
        {
            mayor = num;
        }
    }
    Console.WriteLine("El numero mas grande es "+ mayor);
}

//ejercicio 6
void ej6()
{
    Console.WriteLine("");
    Console.WriteLine("Inserte su nombre:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Bienvenido " + char.ToUpper(nombre[0]) + nombre.Substring(1));
  
}


//ejercicio 7
void ej7()
{
    Console.WriteLine("");
    Console.WriteLine("A continuacion la tabla del 7 ");
    for (int  l = 1; l <= 10; l++)
    {
        int mult = l * 7;
        Console.WriteLine(l + " x 7 = "+ mult);
    }
}

//ejercicio 8
void ej8()
{
    Console.WriteLine("");
    Console.WriteLine("Cuenta regresiva del 10 al 1");
    for (int j = 10; j > 0 ; j--) 
    {
        Console.WriteLine(j);
        if(j == 1)
        {
            Console.WriteLine("OAAAAAAAAAAAAAAAAAAAA");
        }
    }
}

//ejercicio 9
void ej9()
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa un numero para identificar si es par o impar ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("El numero es PAR");
    }
    else
    {
        Console.WriteLine("El numero es IMPAR");
    }
}
//ejercicio 10
void ej10()
{
    Console.WriteLine("");
    Console.WriteLine("Escriba una frase para ver cuantas vocales contiene");
    String frase2;
    frase2 = Console.ReadLine();
    int contvocal = 0;
    string vocales = "AEIOUaeiou";

    foreach (Char f in frase2)
    {
        foreach (char v in vocales)
        {
            if (f == v)
            {
                contvocal = contvocal + 1;
                break;
            }
        }
    }
    Console.WriteLine("El texto tiene " + contvocal + " vocales");

}

//ejercicio 11
void ej11()
{
    Console.WriteLine("");
    Console.WriteLine("Inserte un numero para mostrar su tabla de multiplicar del 1 al 12");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int l = 1; l <= 12; l++)
    {
        int mult = l * num;
        Console.WriteLine(l + " x "+ num +" = " + mult);
    }
}

//ejercicio 12
void ej12()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese numeros ramdon, si la suma de estos supera 100 hasta ahi llega:");
    int num;
    int acum = 0;
    while (acum < 100)
    {
        num = Convert.ToInt32(Console.ReadLine());
        acum = acum + num;
        if (acum > 100)
        {
            Console.WriteLine("El numero sobrepaso los 100 permitidos");
        }
        else if (acum == 100)
        {
            Console.WriteLine("Como el numero ya llego al limite (100) no se le permite ingresar mas numeros. ");
        }
        else
        {
            Console.WriteLine("Por ahora tiene un total de " + acum + " numeros acumulados.");
        }
    }
}

//ejercicio 13
void ej13()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese una palabra para insertar cada letra en una linea distinta:");
    string palabra = Console.ReadLine();
    for (int i = 0; i < palabra.Length; i++)
    {
        char letra = palabra[i];
        Console.WriteLine(letra);

    }
}

//ejercicio 14
void ej14()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese su edad para ver si puede votar, manejar o hacer ambas:");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad >= 16 & edad < 18)
    {
        Console.WriteLine("Usted tiene " + edad + " años, asi que tiene permitido votar aunque es opcional.");
    }
    else if (edad > 17 & edad <= 100)
    {
        Console.WriteLine("Usted tiene " + edad + " años, asi que ya tiene la edad suficiente para manejar y tiene que votar si o si, o sino se come tremenda multa por bobi.");
    }
    else if (edad > 100)
    {
        Console.WriteLine("Usted tiene "+ edad +"o es un dios que puede vivir milenios o esta escribiendo desde el mas alla.");
    } 
}

//ejercicio 15
void ej15()
{
    Console.WriteLine("");
    Console.WriteLine("Numeros del 50 al 0 de 5 en 5:");
    for (int i = 50; i >= 0; i-=5)
    {
        Console.WriteLine(i);
    }
}

//ejercicio 16
void ej16()
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa una contraseña:");
    string contraseña = "";
    string contraseña2 = "";
    contraseña = Console.ReadLine();
    Console.WriteLine("Ingrese la contraseña nuevamente;");
    while (contraseña != contraseña2)
    {
        contraseña2 = Console.ReadLine();
        if (contraseña2 == contraseña)
        {
            Console.WriteLine("Perfecto");
            break;
        }
        Console.WriteLine("Incorrecto, ingrese de nuevo:");
    }


}

//ejercicio 17
void ej17()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese nombres hasta que el nombre tenga mas de 10 caracteres:");
    string nombre = Console.ReadLine();
    int tamaño = nombre.Length;
    if (tamaño > 10)
    {
        Console.WriteLine("El texto tiene mas de 10 caracteres");
     
    }
    else
    {
        while (tamaño <= 10)
        {
            Console.WriteLine("El numero de caracteres de el nombre " + nombre + " es de " + tamaño);
            if (tamaño > 10)
            {
                Console.WriteLine("El texto tiene mas de 10 caracteres");
                break;
            }
            else if (tamaño == 10)
            {
                Console.WriteLine("El texto tiene 10 caracteres(el limite).");
            }

            Console.WriteLine("Ingrese otro nombre");
            nombre = Console.ReadLine();
            tamaño = nombre.Length;
        }
        if (tamaño > 10)
        {
            Console.WriteLine("El texto tiene mas de 10 caracteres");
        }
    }
        
}

//ejercicio 18
void ej18()
{
    Console.WriteLine("");
    Console.WriteLine("Escriba una frase para ver cuantas vocales 'a' contiene");
    String frase2;
    frase2 = Console.ReadLine();
    int contvocal = 0;
    string vocal = "Aa";

    foreach (Char f in frase2)
    {
        foreach (char v in vocal)
        {
            if (f == v)
            {
                contvocal = contvocal + 1;
                break;
            }
        }
    }
    Console.WriteLine("El texto tiene " + contvocal + " vocales ´A´");
}

//Menu
Console.WriteLine("//============== MENU ===============//");
Console.WriteLine("Elija que ejercicio del 1 al 18 ejecutar, Donde:");
Console.WriteLine("1 = Multiplos de 3 del 1 al 100");
Console.WriteLine("2 = ¿Mayor o menor de edad?");
Console.WriteLine("3 = ¿Cuantas letras contiene la palabra?");
Console.WriteLine("4 = Contraseña secreta");
Console.WriteLine("5 = ¿Cual es el numero mas alto?");
Console.WriteLine("6 = Bienvenido");
Console.WriteLine("7 = Tabla del 7");
Console.WriteLine("8 = Cuenta regresiva desde 10 hasta 1 un poco exaltada");
Console.WriteLine("9 = ¿Par o impar?");
Console.WriteLine("10 = ¿Cuantas vocales?");
Console.WriteLine("11 = Tabla de multiplicar hasta el numero 12");
Console.WriteLine("12 = Solo hasta 100");
Console.WriteLine("13 = Separando letras...");
Console.WriteLine("14 = ¿Votas o manejas?");
Console.WriteLine("15 = Numeros del 50 al 0 de 5 en 5");
Console.WriteLine("16 = Anti alzheimer");
Console.WriteLine("17 = Nombre muy pesado...");
Console.WriteLine("18 = ¿Cuantas 'a' tiene?");
Console.WriteLine("0 = Pa salir");
int menu = Convert.ToInt32(Console.ReadLine());
switch (menu)
{
    case 1:
        ej1();

        break;

    case 2:
        ej2();
        break;

    case 3:
        ej3();

        break;

    case 4:
        ej4();
        break;

    case 5:
        ej5();

        break;

    case 6:
        ej6();
        break;

    case 7:
        ej7();

        break;

    case 8:
        ej8();
        break;

    case 9:
        ej9();

        break;

    case 10:
        ej10();
        break;

    case 11:
        ej11();

        break;

    case 12:
        ej12();
        break;

    case 13:
        ej13();

        break;

    case 14:
        ej14();
        break;

    case 15:
        ej15();

        break;

    case 16:
        ej16();
        break;

    case 17:
        ej17();

        break;

    case 18:
        ej18();
        break;

    case 0:
        Console.WriteLine("Chao tonce");
        break;

    default:
        Console.WriteLine("Opcion invalida");
        break;



}