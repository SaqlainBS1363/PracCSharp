namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello, World!");

            //2
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

            //3
            checked
            {
                int val = int.MaxValue;
                //Console.WriteLine(val + 10);
            }

            //4
            string str1 = "1000", str2 = "";
            int int1 = 200, int2;
            long long1 = 115000000, long2;
            double double1 = 129.0968568459409, double2;
            float float1 = 9.8f, float2;
            bool bool1 = true, bool2;
            char char1 = 'a', char2;

            Console.WriteLine("\n");
            str2 = Convert.ToString(int1);
            int2 = Convert.ToInt32(str1);
            Console.WriteLine("Int to String: " + str2);
            Console.WriteLine("String to Int: " + int2);
            Console.WriteLine("\n");

            str1 = "198000001200";
            str2 = Convert.ToString(long1);
            long2 = Convert.ToInt64(str1);
            Console.WriteLine("String to Long: " + long2);
            Console.WriteLine("Long to String: " + str2);
            Console.WriteLine("\n");

            str1 = "543.906960605858";
            str2 = Convert.ToString(double1);
            double2 = Convert.ToDouble(str1);
            Console.WriteLine("String to Double: " + double2);
            Console.WriteLine("Double to String: " + str2);
            Console.WriteLine("\n");

            str1 = "13.488";
            str2 = Convert.ToString(float1);
            float2 = (float)Convert.ToDouble(str1);
            Console.WriteLine("String to Float: " + float2);
            Console.WriteLine("Float to String: " + str2);
            Console.WriteLine("\n");

            str1 = "false";
            str2 = Convert.ToString(bool1);
            bool2 = Convert.ToBoolean(str1);
            Console.WriteLine("String to Bool: " + bool2);
            Console.WriteLine("Bool to String: " + str2);
            Console.WriteLine("\n");

            int1 = 100;
            int2 = Convert.ToInt32(long1);
            long2 = (long)int1;
            Console.WriteLine("Int to Long: " + long2);
            Console.WriteLine("Long to Int: " + int1);
            Console.WriteLine("\n");

            int1 = 100;
            int2 = (int)char1;
            char2 = (char)int1;
            Console.WriteLine("Int to Char: " + char2);
            Console.WriteLine("Char to Int: " + int2);
            Console.WriteLine("\n");

            //5
            int f1 = 10, f2 = 4;
            Console.WriteLine("10 + 4 = " + (f1+f2));
            Console.WriteLine("10 * 4 = " + (f1 * f2));
            Console.WriteLine("10 - 4 = " + (f1 - f2));
            Console.WriteLine("10 / 4 = " + (f1 / f2));
            Console.WriteLine("10 % 4 = " + (f1 % f2));
            Console.WriteLine("10 OR 4 = " + (f1 | f2));
            Console.WriteLine("10 AND 4 = " + (f1 & f2));
            Console.WriteLine("10 XOR 4 = " + (f1 ^ f2));

            //6
            if (int1 > int2)
                Console.WriteLine("" + int1 + " is bigger than " + int2);
            else if (int1 == int2)
                Console.WriteLine("" + int1 + " is equal to " + int2);
            else
                Console.WriteLine("" + int1 + " is smaller than " + int1);

            //7
            if (bool1 && bool2)
                Console.WriteLine("Both True!");
            else if (bool1 || bool2)
                Console.WriteLine("Only one is true");

            //8
            var ans = int1 > int2 ? int1 + " is greater than " + int2 : int1 + " is less than " + int2;
            Console.WriteLine(ans);


            //9
            //Comment type-1: Single line comment

            /*
             * Comment type-2: Multiple line comment
             */


            //10
            Console.WriteLine("\n\n");
            Console.WriteLine("For loop: \n");
            int i = 0;
            for(i = 1; i <= 100; i++)
            {
                if (i == 95)
                    continue;
                Console.Write(i + " ");
                if (i == 99)
                    break;
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("While loop: \n");
            i = 1;
            while(i <= 100)
            {
                if (i == 95)
                {
                    i++;
                    continue;
                }
                Console.Write(i + " ");
                if (i == 99)
                    break;
                i++;
            }
            Console.WriteLine("\n\n");


            Console.WriteLine("Do-while loop: \n");
            i = 1;
            do
            {
                if (i == 95)
                {
                    i++;
                    continue;
                }
                Console.Write(i + " ");
                if (i == 99)
                    break;
                i++;
            } while(i <= 100);
            Console.WriteLine("\n\n");


            Console.WriteLine("Foreach loop: \n");
            foreach (var x in Enumerable.Range(0,100))
            {
                if (x == 95)
                    continue;
                Console.Write(x + " ");
                if (x == 99)
                    break;
            }
            Console.WriteLine("\n\n");

            //11
            int position = 5;
            switch (position)
            {
                case 1:
                    Console.WriteLine("1st position");
                    break;
                case 2:
                    Console.WriteLine("2nd position");
                    break;
                case 3:
                    Console.WriteLine("3rd position");
                    break;
                case 4:
                    Console.WriteLine("4th position");
                    break;
                case 5:
                    Console.WriteLine("5th position");
                    break;
                case 6:
                    Console.WriteLine("6th position");
                    break;
                default:
                    Console.WriteLine("Honourable Mention");
                    break;
            }
        }
    }
}