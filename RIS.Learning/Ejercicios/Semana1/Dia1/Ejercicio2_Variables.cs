namespace Ejercicios.Semana1.Dia1;

public static class Ejercicio2_Variables
{
    public static void Run()
    {
        // Datos básicos del paciente
        string nombre = "María Pérez";
        int edad = 42;
        decimal peso = 68.5m;
        decimal altura = 1.65m;
        bool esAlergico = false;
        DateTime fechaNacimiento = new DateTime(1983, 4, 15);
        Guid idPaciente = Guid.NewGuid();

        Console.WriteLine("===================================");
        Console.WriteLine("   BLOQUE 2 – Variables en el RIS");
        Console.WriteLine("===================================\n");

        Console.WriteLine($"ID Paciente: {idPaciente}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Peso: {peso} kg");
        Console.WriteLine($"Altura: {altura} m");
        Console.WriteLine($"¿Es alérgico?: {esAlergico}");
        Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento:dd/MM/yyyy}\n");

        // Tipos anulables (nullable)
        int? presionSistolica = null;  // no medida aún
        DateTime? fechaUltimoEstudio = null;

        Console.WriteLine("Valores aún no registrados:");
        Console.WriteLine($"Presión sistólica: {presionSistolica}");
        Console.WriteLine($"Último estudio: {fechaUltimoEstudio}");
    }
}