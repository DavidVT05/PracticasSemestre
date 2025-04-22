using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    // Metodo para comprobar si un numero es primo 
    static bool EsPrimo(int numero)
    {
        //Indicamos que los numeros menores a 1 no son primos
        if(numero <= 1) return false;
        //Se comprueba si los numeros son divisibles entre dos y su raiz cuadrada
        for(int i = 2; i * i <= numero; i++) 
        {
            //Indicamos si el numero es divisible entre i no es primo
            if (numero % i == 0) return false;
        }
        return true; // Indicamos que si no se encontro ningun divisor el numero es primo
    }
    // Metodo que realiza la suma de los numeros primos en un rango determinado
    static int SumarNumerosPrimos(int inicio, int fin)
    {
        int suma = 0; 
        for(int i = inicio; i <= fin; i++)
        {
            if (EsPrimo(i))
                suma += i;
        }
        return suma;
    }
    //Funcion que realiza el calculo de los numeros primos en un hilo
    static void CalcularNumerosPrimos(int inicio, int fin,List<int> resultado)
    {
        int suma = SumarNumerosPrimos(inicio, fin);
        lock (resultado)  // Se utiliza Lock para asegurar que la lista no se modifique  
        {
            resultado.Add(suma);
        }
    }
    static void Main(string[] args)
    {
        //Valores que ingresara el usuario 
        Console.WriteLine("Ingresar el valor de N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresar el numero de segmentos (M):");
        int M = int.Parse(Console.ReadLine());
        //Se divide el rango de numeros del 1 asta el N en M segmentos
        int segmentoSize = N / M;
        //se preparan los hilos
        Thread[] hilos = new Thread[M];
        List<int> resultados = new List<int>();
        //Realizamos la medicion del tiempo de ejecucion secuencial.
        Stopwatch stopwatchSec = Stopwatch.StartNew();
        int sumaSec = SumarNumerosPrimos(1, N);
        stopwatchSec.Stop();
        Console.WriteLine($"La suma secuencial es:{sumaSec}");
        Console.WriteLine($"El tiempo de ejecucion secuencial es: {stopwatchSec.ElapsedMilliseconds} ms");
        //Medimos el tiempo de la ejecucion concurrente
        Stopwatch stopwatchCon = Stopwatch.StartNew();
        for (int i = 0; i < M; i++)
        {
            int inicio = i * segmentoSize + 1;
            int fin = (i == M - 1) ? N : (inicio + segmentoSize - 1);
            //se crea un hilo para cada segmento
            hilos[i] = new Thread(() => CalcularNumerosPrimos(inicio, fin, resultados));
            hilos[i].Start();
        }
        //Se espera a que todos los hilos terminen 
        for(int i = 0; i < M; i++)
        {
            hilos[i].Join();
        }
        //Calculamos la suma total de los resultados
        int sumaCon = 0;
        foreach(int resultado in resultados)
        {
            sumaCon += resultado;
        }
        stopwatchCon.Stop();
        Console.WriteLine($"La suma concurrente es: {sumaCon}");
        Console.WriteLine($"El tiempo de ejecucion concurrente: {stopwatchCon.ElapsedMilliseconds} ms");

    }
}