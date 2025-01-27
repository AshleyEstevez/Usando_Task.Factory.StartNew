using System;
using System.Threading.Tasks;

internal class Program
{
    static async Task Main()
    {
        Task task = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tarea ejecutándose: {i}");
            }
        }, TaskCreationOptions.LongRunning);

        // La última línea "Tarea completada." no se mostrara si no esperamos a que la tarea termine.
        // Esto ocurre porque Task.Factory.StartNew ejecuta la tarea de manera asíncrona,
        // pero el hilo principal no espera a que la tarea termine antes de continuar con la ejecución.
        // Esto puede hacer que el programa termine antes de que la tarea se complete.

        // Solución: Usar 'await task;' para esperar a que la tarea termine antes de continuar.

        await task;

        Console.WriteLine("Tarea completada.");
    }
}

