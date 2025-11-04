using Ejercicios.Semana1.Dia1;

Console.WriteLine("=====================================");
Console.WriteLine("  RIS Learning Journey — Semana 1");
Console.WriteLine("=====================================\n");
Console.WriteLine("1) S1D1-01 — Bloque 1: Hola Mundo");
Console.WriteLine("2) S1D1-02 — Bloque 2: Variables");
Console.Write("\nElige 1 o 2: ");

string? op = Console.ReadLine()?.Trim();

switch (op)
{
    case "1":
        Ejercicio1_HolaMundo.Run();
        break;
    case "2":
        Ejercicio2_Variables.Run();
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

Console.WriteLine("\nFin. Presiona ENTER para salir.");
Console.ReadLine();