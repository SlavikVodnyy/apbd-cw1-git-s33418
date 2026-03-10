namespace Task1
{
    public abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(list.Where(x => x % 2 == 0).Sum());
        }

        public static void Avg(List<int> list)
        {
            Console.WriteLine(list.Average());
        }
    }
}