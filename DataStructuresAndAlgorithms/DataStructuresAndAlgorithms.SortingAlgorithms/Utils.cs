using System.Diagnostics;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public static class Utils
    {
        public static void Print(this int[] arr) => Console.WriteLine(String.Join(",", arr));
        public static void PrintTitle(this string message) => Console.WriteLine($"|=*=*=*=*=*=*=|=*=*=*=*=*=*=| {message} |=*=*=*=*=*=*=|=*=*=*=*=*=*=|");
        public static int[] GetRandomArray(int maxRange, int limitRandom) => Enumerable.Range(0,maxRange)
                                                                            .Select(x => new Random().Next(limitRandom))
                                                                            .ToArray();
        public static bool GreaterThan(this int a, int b) => a > b;
        public static void Swapp(this int[] arr, int idx)
        {
            int tmp = arr[idx];
            arr[idx] = arr[idx + 1];
            arr[idx + 1] = tmp;
        }
        public static class Runtime
        {
            public static Stopwatch sw; 
            public static void Start()
            {
                sw = Stopwatch.StartNew();
                sw.Start();
            }
            public static void Stop()
            {
                sw.Stop();
                Console.WriteLine($"Tiempo de ejecución en milisegundos: {sw.Elapsed.TotalMilliseconds}");
                
            }
        }
    }
}
