using Generics;

class Program
{
    static void Main()
    {
        CustomArray<int> array = new CustomArray<int>(5);
        array.Add(1);
        array.Add(2);
        array.Add(3);
        array.Print(); // 1 2 3

        array.Delete(1);
        array.Print(); // 1 0 3

        int first = array.FindFirst(x => x > 1);
        Console.WriteLine(first); // 3

        array.Swap(0, 2);
        array.Print(); // 3 0 1
    }
}
