// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Ejercicios;
using static System.Runtime.InteropServices.JavaScript.JSType;

while (true)
{
    Console.Clear();
    Console.WriteLine("Favor de ingresar el numero del proceso que desea calcular: ");
    Console.WriteLine("1. Interes Generado");
    Console.WriteLine("2. Conversion entre divisas");
    var Opcion = Console.ReadLine();
    try
    {
        Console.Clear();
        switch (int.Parse(Opcion))
        {
            case 1:
                Ejercicio1 InteresGenerado = new Ejercicio1();
                InteresGenerado.llenardatos();
                break;
            case 2:
                Ejercicio2 ConversionDivisas = new Ejercicio2();
                break;
            default:
                break;
        }
        //Console.WriteLine("Para regresar al menu principal presione la tecla Enter");
        //while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    }
    catch{}
}
