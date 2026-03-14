namespace Task1
{
    public abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new() { 1, 2, 3, 4, 5, 6 };
            int[] custom = new int[5];
            Console.WriteLine(list.Where(x => x % 2 == 0).Sum());
            Console.WriteLine("Enter 2 numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int mulRes = number1 * number2;
            float divRes = number1 / number2;
            Console.WriteLine($"Multiplication result: {mulRes}, Division result: {divRes}");
            Avg(list, custom);
            CalculateMax(list);

        }

        public static void Avg(List<int> list, int[] custom)
        {
            Console.WriteLine($"List average: {list.Average()}");
            for (int i = 0; i < custom.Length; i++)
            {
                Console.WriteLine($"Write {i + 1} number: ");
                custom[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Your's array average: {custom.Average()}");
        }

        public static void CalculateMax(List<int> list)
        {
            Console.WriteLine($"Max number in list: {list.Max()}");
        }

        public static void CalculateMin(List<int> list)
        {
            
        }

    }
}