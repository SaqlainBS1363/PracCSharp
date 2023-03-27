namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num1 = 10;
            long num2 = 1000000000;
            float num3 = 5.140f;
            double num4 = 63.25697458;
            char num5 = 'a';
            string num6 = "CSE";
            bool num7 = true;

            Console.WriteLine("Int: " + num1);
            Console.WriteLine("Long: " + num2);
            Console.WriteLine("Float: " + num3);
            Console.WriteLine("Double: " + num4);
            Console.WriteLine("Char: " + num5);
            Console.WriteLine("String: " + num6);
            Console.WriteLine("Bool: " + num7);

            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 10);
            }
        }
    }
}