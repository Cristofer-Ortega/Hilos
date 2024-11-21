using System;
using System.Threading;

class Program
{
    static int num1, num2;

    static void Main(string[] args)
    {
        // Crear hilos para la suma y la resta
        Thread sumaThread = new Thread(Sumar);
        Thread restaThread = new Thread(Restaurar);

        // Pedir al usuario los números
        Console.WriteLine("Introduce el primer número:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Iniciar los hilos
        sumaThread.Start();
        restaThread.Start();

        // Esperar a que ambos hilos terminen
        sumaThread.Join();
        restaThread.Join();

        Console.WriteLine("Operaciones completadas.");
    }

    static void Sumar()
    {
        int resultadoSuma = num1 + num2;
        Console.WriteLine($"La suma de {num1} y {num2} es: {resultadoSuma}");
    }

    static void Restaurar()
    {
        int resultadoResta = num1 - num2;
        Console.WriteLine($"La resta de {num1} y {num2} es: {resultadoResta}");
    }
}
