using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PracCSharp
{
    internal partial class Program
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
            Console.WriteLine("\n\n");


            //3
            try
            {
                checked
                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 10);
                }
            }catch (OverflowException e) {
                Console.WriteLine("Value overflowed");
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


            //12
            Console.WriteLine("\n\n");
            CSharpBasics S1 = new CSharpBasics("BS1363", "Md. Anwarul Habib");
            S1.Introduce();


            //13.
            Console.WriteLine("\n\n");
            Practice P1 = new Practice();
            P1.Initialize("Saqlain", "BS1363");
            P1.Display();


            //14
            Console.WriteLine("\n\n");
            S1.Introduce();
            Console.WriteLine("");
            CSharpBasics S2 = S1;
            S2.traineeName = "Saqlain";
            S1.Introduce();

            Console.WriteLine("");
            var x1 = 10;
            var y1 = x1;
            Console.WriteLine("1. X1 = " + x1 + ", Y1 = " + y1);
            y1++;
            Console.WriteLine("2. X1 = " + x1 + ", Y1 = " + y1);


            //15
            var intArray = new int[15];
            var longArray = new long[15];
            var doubleArray = new double[15];
            var boolArray = new bool[15];
            var charArray = new char[15];
            var stringArray = new string[15];


            //16
            int intN = 1;
            for(int j = 0; j < 15; j++, intN++)
                intArray[j] = intN;

            long longN = 1;
            for(int j = 0; j < 15; j++, longN++)
                longArray[j] = longN;

            double doubleN = 1.0;
            for (int j = 0; j < 15; j++, doubleN += 0.5)
                doubleArray[j] = doubleN;

            bool boolN = false;
            for (int j = 0; j < 15; j++)
            {
                if (j % 2 == 0)
                    boolN = true;
                else
                    boolN = false;
                boolArray[j] = boolN;
            }

            char charN = 'a';
            for (int j = 0; j < 15; j++, charN++)                
                charArray[j] = charN;

            string stringN = "a";
            charN = 'a';
            for (int j = 0; j < 15; j++, charN++)
            {
                stringArray[j] = stringN;
                stringN += charN;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("For loop: \n");
            Console.WriteLine("Int\tLong\tDouble\tChar\tBool\tString\n");
            for (i = 0; i < 15; i++)
            {
                if (i == 5)
                    continue;
                Console.Write(intArray[i] + "\t" + longArray[i] + "\t" + doubleArray[i] + "\t");
                Console.Write(charArray[i] + "\t" + boolArray[i] + "\t" + stringArray[i]);
                Console.WriteLine("");
                if (i == 10)
                    break;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("While loop: \n");
            Console.WriteLine("Int\tLong\tDouble\tChar\tBool\tString\n");
            i = 1;
            while (i < 15)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }
                Console.Write(intArray[i] + "\t" + longArray[i] + "\t" + doubleArray[i] + "\t");
                Console.Write(charArray[i] + "\t" + boolArray[i] + "\t" + stringArray[i]);
                Console.WriteLine("");
                if (i == 10)
                    break;
                i++;
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Foreach loop: \n");
            foreach (var x in intArray)
            {
                if (x == 5)
                    continue;
                Console.Write(x + " ");
                if (x == 10)
                    break;
            }


            //17
            Console.WriteLine("\n\n");
            Days days = Days.Sunday;
            var dayName = days;
            Console.WriteLine("The desired day: " + dayName);

            string JumwaDay = "Friday";
            days = (Days)Enum.Parse(typeof(Days), JumwaDay, true);
            Console.WriteLine("Jumma day is: " + days);


            //18
            Console.WriteLine("\n\n");

            //Class1 c1 = new Class1("BS1");
            Class2 c2 = new Class2("BS2");

            Console.WriteLine();
            Class1.work();
            c2.work();


            //19
            Console.WriteLine("\n\n");
            List<int> intList = new List<int>() { 3, 2, 1};
            List<double> doubleList = new List<double>() { 3.554, 56.09189, 1.2};
            List<string> stringList = new List<string>() { "CSE", "EEE", "IPE"};

            intList.Add(4);
            intList.AddRange(new List<int>(){ 5, 6});
            intList.Sort();
            intList.Remove(4);
            intList.Insert(3, 12);

            Console.Write("Int list: ");
            for (i = 0; i < intList.Count; i++)
                Console.Write(intList[i] + " ");
            Console.WriteLine("");


            //20.
            Console.WriteLine("\n\n");
            int[] intArray1 = new int[4];
            double[] doubleArray1 = new double[4];
            string[] stringArray1 = new string[4];


            intN = 1;
            for (int j = 0; j < 4; j++, intN++)
                intArray1[j] = intN;

            doubleN = 1.0;
            for (int j = 0; j < 4; j++, doubleN += 0.5)
                doubleArray1[j] = doubleN;

            stringN = "a";
            charN = 'a';
            for (int j = 0; j < 4; j++, charN++)
            {
                stringArray1[j] = stringN;
                stringN += charN;
            }

            Array.Sort(intArray1);
            Array.Reverse(intArray1);
            Array.Clear(intArray1);

            Console.Write("Int array: ");
            for (i = 0; i < intArray1.Length; i++)
                Console.Write(intArray1[i] + " ");
            Console.WriteLine("");


            //21.
            Console.WriteLine("\n\n");
            var dateTime = new DateTime(2023, 4, 4);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Current Date: ", now.Date);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tomorrow: " + tomorrow.Date);
            Console.WriteLine("Yesterday: " + yesterday.Date);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());


            //22.
            Console.WriteLine("\n\n");
            str1 = "Brain Station 23 Ltd.";
            str1.Replace('n', 'N');
            str1.PadRight(2, ' ');
            str1.Replace(' ', '~');
            str1.Concat(" BS1363 ");
            str1.Trim();
            str1.ToUpperInvariant();
            str1.ToLowerInvariant();
            str1.Substring(0, 2);


            //23.
            Console.WriteLine("\n\n");
            var strModification = new StringBuilder();

            strModification.Append('~', 20)
                .AppendLine()
                .Append("CSE")
                .AppendLine()
                .Append('-', 20);

            Console.WriteLine("Str Builder: \n" + strModification);

            strModification.Replace('-', '*');
            Console.WriteLine("Str Builder: \n" + strModification);

            strModification.Remove(0, 5);
            Console.WriteLine("Str Builder: \n" + strModification);

            strModification.Insert(5, new string('^', 5));
            Console.WriteLine("Str Builder: \n" + strModification);


            Console.WriteLine("\nGood bye Saqlain\n");
        }
    }
}