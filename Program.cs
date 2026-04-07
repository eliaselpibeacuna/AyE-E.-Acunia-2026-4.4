// Ejercicio 1: Contraseña secreta

Console.WriteLine("Ingrese la contraseña secreta (en definitiva no es Quesito777)");
String Contraseña = Console.ReadLine();
while (Contraseña != "Quesito777"){

    Console.WriteLine("Contraseña incorrecta, intentelo de nuevo");
    Contraseña = Console.ReadLine();
}
Console.WriteLine("Contraseña correcta, Entrando...");

// Ejercicio 2: Despegue!

Console.WriteLine("");
Console.WriteLine("A Continuacion una cuenta regresiva antes del despegue");
for (int x = 5; x >= 1; x--)
{
    Console.WriteLine(x);
}
Console.WriteLine("¿Listo para despegar?");
Console.WriteLine("¡¡Despegue!!");

// Ejercicio 3: Numero Secreto

Console.WriteLine("");
Console.WriteLine("Adivina el numero secreto");
int numsecreto = Convert.ToInt32(Console.ReadLine());
while (numsecreto != 7)
{
    Console.WriteLine("Numero erroneo");
    numsecreto = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Adivinaste!!");

// Ejercicio 4: Muchas sumas!
Console.WriteLine("");
Console.WriteLine("Escriba numeros para sumarlos, si quiere terminar la suma ingrese 0");
int acum = 0;
int num1 = Convert.ToInt32(Console.ReadLine());

while (num1 != 0) {

    acum = acum + num1;
    num1 = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("La suma total es de");
Console.Write(acum);