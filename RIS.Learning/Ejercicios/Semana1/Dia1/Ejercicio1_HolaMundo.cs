namespace Ejercicios.Semana1.Dia1;

public static class Ejercicio1_HolaMundo
{
    public static void Run()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("     API RIS — Día 1: Hola Mundo");
        Console.WriteLine("=======================================\n");

        string nombre = "Lidis";
        string mensajeBienvenida = "¡Bienvenida al viaje backend para RIS!";
        string proposito = "Aprender C# y .NET 9 para construir una API REST profesional.";

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Mensaje: {mensajeBienvenida}");
        Console.WriteLine($"Propósito: {proposito}\n");

        Console.WriteLine("Presiona ENTER para salir...");
        Console.ReadLine();
    }
}