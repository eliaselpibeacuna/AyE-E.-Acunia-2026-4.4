string abc;
abc = "abcdefghijklmnñopqrstuvwxyz";

//Funcion 1
string funcion1(string abc)
{
    bool valido = false;
    string texto = "";
    while (!valido)
    {
        Console.WriteLine("Escribi tu texto para cifrar o descifrar.");
        texto = Console.ReadLine();
        texto = texto.ToLower();
        bool error = false;

        for (int j = 0; j < texto.Length; j++)
        {
            char caracter = texto[j];
            bool encontrado = false;

            for (int k = 0; k < abc.Length; k++)
            {
                if (caracter == abc[k])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                error = true;
                break;

            }

        }
        if (error)
        {
            Console.WriteLine("Usted inserto un caracter no deseado");
        }
        else
        {
            valido = true;
        }
    }
    return texto;

}



//funcion 2

string cifrado(string nuevotexto, string abc)
{
    Console.WriteLine("Escribi la clave a cifrar:");
    int clave = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("La palabra " + nuevotexto + " cifrada quedaria de la siguiente manera:");

    string textocif = "";

    for (int x = 0; x < nuevotexto.Length; x++)
    {
        for (int i = 0; i < abc.Length; i++)
        {
            if (nuevotexto[x] == abc[i])
            {
                textocif += abc[(i + clave) % abc.Length];
                break;
            }
        }
    }

    return textocif;
}
string descifrado(string nuevotexto, string abc)
{
    Console.WriteLine("Escribi la clave a descifrar:");
    int clave = Convert.ToInt32(Console.ReadLine());
    string textodes = "";
    Console.WriteLine("La palabra " + nuevotexto + " descifrada quedaria de la siguiente manera:");

    for (int x = 0; x < nuevotexto.Length; x++)
    {
        for (int i = 0; i < abc.Length; i++)
        {
            if (nuevotexto[x] == abc[i])
            {
                textodes += abc[(i - clave + abc.Length) % abc.Length];

                break;

            }

        }

    }
    return textodes;


}

// Menu
Console.WriteLine("CIFRADO CESAR");
string nuevotexto = funcion1(abc);
Console.WriteLine("Pulse 1 para cifrar, 2 para descifrar y 0 para cerrar el programa:");
int menu;
menu = Convert.ToInt32(Console.ReadLine());
switch (menu)
{
    case 1:
        Console.WriteLine(cifrado(nuevotexto, abc));
        break;

    case 2:
        Console.WriteLine(descifrado(nuevotexto, abc));

        break;

    case 0:
        break;

    default:

        Console.WriteLine("No pulsaste ningun numero adjuntado");

        break;
}