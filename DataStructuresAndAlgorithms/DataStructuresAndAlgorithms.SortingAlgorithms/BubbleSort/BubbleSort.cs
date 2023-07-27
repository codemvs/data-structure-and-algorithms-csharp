using System.Reflection;

namespace DataStructuresAndAlgorithms.SortingAlgorithms.BubbleSort
{
    public class BubbleSort
    {
        public BubbleSort() {
            "Algoritmo Burbuja".PrintTitle();

            Random random = new Random();
            int[] arr = Utils.GetRandomArray(10,10);

            Console.WriteLine("Elementos desordenados:");
            arr.Print();

            Console.WriteLine("Ordenando... ");
            Utils.Runtime.Start();
            SortPlus(arr);
            Utils.Runtime.Stop();

            Console.WriteLine("Elementos ordenados:");
            arr.Print();

        }
        private void Sort(int[] arr)
        {
            int size = arr.Length-1;
            int tmp = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swapp
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }
        private void SortPlus(int[] arr)
        {
            int size = arr.Length - 1;
            int tmp = 0;
            bool swapped = true;
            for (int i = 0; i < size && swapped; i++)
            {
                swapped = false;
                for (int j = 0; j < size - i ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swapp
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        swapped = true;
                    }
                }
            }
        }
        private void SortClean(int[] arr)
        {
            int size = arr.Length - 1;            
            bool swapped = true;
            for (int i = 0; i < size && swapped; i++)
            {
                swapped = false;
                for (int j = 0; j < size - i; j++)
                {
                    if (arr[j].GreaterThan(arr[j + 1]))
                    {
                        // Intercambio
                        arr.Swapp(j);
                        swapped = true;
                    }
                }
            }
        }
    }
}
