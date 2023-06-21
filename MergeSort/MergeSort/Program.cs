using MergeSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 3, 6, 7, 5, 1, 2, 4, 8, 9 };

        Console.WriteLine("Массив: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        // Рекурсивный подход
        RecursiveMergeSort.Sort(arr);
        Console.WriteLine("Результат сортировки с использованием рекурсивного подхода:");
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine();

        int[] arr2 = { 5, 2, 8, 4, 1, 9, 6, 3, 7 };

        Console.WriteLine("Массив: ");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Метод двух указателей
        TwoPointerMergeSort.Sort(arr2);
        Console.WriteLine("Результат сортировки с использованием метода двух указателей:");
        Console.WriteLine(string.Join(" ", arr2));
    }
}