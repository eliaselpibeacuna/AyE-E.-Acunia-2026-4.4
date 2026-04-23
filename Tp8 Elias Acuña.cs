// Ejercicio 1

Console.WriteLine("Escriba una frase para ver cuantas vocales contiene");
String frase;
frase = Console.ReadLine();
int acum = 0;
foreach (Char a in frase)
{
    if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
    {
        acum = acum + 1;
    }
}
Console.WriteLine("El texto tiene " + acum + " vocales");

// Ejercicio 1 v2
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

// Ejercicio 2

Console.WriteLine("");
Console.WriteLine("Escriba una frase para invertirla ej si escribis 'hola' sera 'aloh'");
string frase3;
frase3 = Console.ReadLine();
char[] arraychars = frase3.ToCharArray();
Array.Reverse(arraychars);
string fraseinvertida = new string(arraychars);
Console.WriteLine(fraseinvertida);

// Ejercicio 3

Console.WriteLine("");
Console.WriteLine("Escribe un numero entero para sumar sus digitos:");
string num = Console.ReadLine();
int aux = 0;
int aux2 = 0;
foreach (char c in num)
{
    aux = Convert.ToInt32("" + c);
    aux2 = aux + aux2;

}
Console.WriteLine("La suma de los digitos del numero es de " + aux2);

// Ejercicio 4

Console.WriteLine("");
Console.WriteLine("Escriba un texto, una palabra prohibida y una palabra de remplazo la palabra prohibida se remplazara por la que escriba en la palabra de remplazo.");
string texto;
texto = Console.ReadLine();
Console.WriteLine("Escriba la palabra prohibida");
string palabraprohibida = Console.ReadLine();
Console.WriteLine("Escriba la palabra de remplazo");
string palabraderemplazo = Console.ReadLine();
string nuevotexto = "";
if (texto.Contains(palabraprohibida) == true)
{
    Console.WriteLine("El texto quedaria asi:");
    nuevotexto = texto.Replace(palabraprohibida, palabraderemplazo);

}
else
{
    Console.WriteLine("Como el texto no contiene la palabra prohibida, queda exactamente igual:");
    Console.WriteLine(texto);
}
Console.WriteLine(nuevotexto);


// Ejercicio 5

Console.WriteLine("");
Console.WriteLine("Ingrese su primer nombre");
string nombre;
string apellido;
string iniciales;
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su primer apellido");
apellido = Console.ReadLine();
nombre = nombre.ToUpper();
apellido = apellido.ToUpper();
iniciales = nombre[0] + "." + apellido[0];
Console.WriteLine("Su primer nombre es " + nombre);
Console.WriteLine("Su primer apellido es " + apellido);
Console.WriteLine("Y sus iniciales son " + iniciales);

// Ejercicio 6

Console.WriteLine("");
Console.WriteLine("Escriba una palabra para saber si es un palindromo o no");
string palindromo;
palindromo = Console.ReadLine();
string minuscula = palindromo.ToLower();
char[] invertir = minuscula.ToCharArray();
Array.Reverse(invertir);
string palindromoinvertido = new string(invertir);
if (minuscula == palindromoinvertido)
{
    Console.WriteLine("La palabra " + palindromo + " es un palindromo.");
}
else
{
    Console.WriteLine("La palabra " + palindromo + " NO es un palindromo.");
}
