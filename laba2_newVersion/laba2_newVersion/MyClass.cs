using System;
using System.Text;


namespace laba2
{
    class MyClass
    {
        public static (int minn, int maxx,int summ,char firstSembol)testmetod(int[] arr, string str)
        {
            int min = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            char first = str[0];
            var result = (minn: min, maxx: max, summ: sum,firstSembol:first);
            return result;
        }


           
        static void Main(string[] args)
        {
            //1.1
            int intVar = 1;
            byte byteVar = 2;
            bool bollVar = false;
            sbyte sbyteVar = 2;
            char charVar = 'Z';
            short shortVar = 12;
            ushort ushortVar = 32;
            long longVar = 8000;
            ulong ulongVar = 56789;
            float floatVar = 0;
            double doubleVar = 0.181;
            //1.2
            intVar = byteVar;
            intVar = sbyteVar;
            doubleVar = floatVar;
            doubleVar = ulongVar;
            doubleVar = shortVar;

            byteVar = (byte)intVar;
            sbyteVar = (sbyte)intVar;
            floatVar = (float)doubleVar;
            ulongVar = (ulong)doubleVar;
            shortVar = (short)doubleVar;
            //1.3
            int boxVar = 5;
            Object wrapper = boxVar;
            int onboxVar = (int)wrapper;
            //1.4
            var mbString = "hello world";
            var mbInt32 = 3456;
            //1.5
            int? nullVar = null;
            /////////////////////////
            //2.1
            string firstString = "petr";
            string secondString = "sobolev";
            if (firstString == secondString) bollVar = true;
            string nameAndSecondName = firstString + secondString;
            nameAndSecondName.Substring(firstString.Length, secondString.Length);
            string thirdString = firstString;
            string concatString = String.Concat(firstString, secondString, thirdString);
            string moreWords = "my name is petr sobolev";
            for (int i0 = 0; i0 < moreWords.Length; i0++)
            {
                if (moreWords[i0] != ' ')
                {
                    Console.Write(moreWords[i0]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            string newString = moreWords.Remove(1, 5);
            //2.2
            string stringEmpty = " ";
            string nullString = null;
            //2.3
            StringBuilder MyStringBuilder = new StringBuilder("Hello World!");
            MyStringBuilder.Append(" What a beautiful day.");
            Console.WriteLine(MyStringBuilder);
            /////////
            int MyInt = 25;
            StringBuilder MyStringBuilder1 = new StringBuilder("Your total is ");
            MyStringBuilder.AppendFormat("{0:C} ", MyInt);
            Console.WriteLine(MyStringBuilder);
            /////////////////////
            StringBuilder MyStringBuilder2 = new StringBuilder("Hello World!");
            MyStringBuilder.Insert(6, "Beautiful ");
            Console.WriteLine(MyStringBuilder);

            ///////////////////////////
            StringBuilder MyStringBuilder3 = new StringBuilder("Hello World!");
            MyStringBuilder.Remove(5, 7);
            Console.WriteLine(MyStringBuilder);

            ////3.1
            int[,] numbers = new int[2, 2];

            for (int n = 0; n < 2; n++)
            {
                for (int m = 0; m < 2; m++)
                {
                    Console.WriteLine("Enter number: ");
                    numbers[n, m] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }


            for (int i1 = 0; i1 < 2; i1++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(numbers[i1, j] + " ");
                }
                Console.WriteLine();




            }
            int size;
            Console.WriteLine("введите размер строкового массива");
            size = Convert.ToInt32(Console.ReadLine());
            string[] myArrString = new string[size];
            Console.WriteLine("введите строки");
            for (int i2 = 0; i2 < size; i2++)
            {
                myArrString[i2] = Console.ReadLine();
            }
            for (int i3 = 0; i3 < size; i3++)
            {
                Console.WriteLine(myArrString[i3]);
            }

            Console.WriteLine("длинна строкового массива" + size);
            Console.WriteLine("какие элементы поменять местами");
            int firstElement = int.Parse(Console.ReadLine());
            int secondElement=int.Parse(Console.ReadLine());
            string buff;
            buff = myArrString[firstElement];
            myArrString[firstElement] = myArrString[secondElement];
            myArrString[secondElement] = buff;

            for (int i4 = 0; i4 < size; i4++)
            {
                Console.WriteLine(myArrString[i4]);
            }
            ////////////////////////////////////////////////3.3
            int i = 0;
            double[][] steapArr = new double[3][];
            
            steapArr[0]=new double[2];
            steapArr[1] = new double[3];
            steapArr[2] = new double[4];
            Console.WriteLine("заполните зубчатый массив");
            for (; i < 2; i++)
            {
                steapArr[0][i] = double.Parse(Console.ReadLine());
                Console.Write("{0}\t", steapArr[0][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 3; i++)
            {
                steapArr[1][i] = double.Parse(Console.ReadLine());
                Console.Write("{0}\t", steapArr[1][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                steapArr[2][i] = double.Parse(Console.ReadLine());
                Console.Write("{0}\t", steapArr[2][i]);
            }

            //3.4/////////////////////////////////////////
            var vals = new[] { 1, 2, 3, 4, 5 };
            var str =  "надоело, второй час херней страдаю ****************" ;
            ///4.1//////////////////////////
            ///
           
            (int,string,char,string,ulong) tuple2= (number:1,string1: "petya", simbol:'a',string2: "vasia",number2:1000);
            (int, string, char, string, ulong) tuple3 = (number: 1, string1: "petya", simbol: 'a', string2: "vasia", number2: 1000);

            Console.WriteLine(tuple2.Item1);
            Console.WriteLine(tuple2.Item2);
            Console.WriteLine(tuple2.Item3);
            Console.WriteLine(tuple2.Item4);
            Console.WriteLine(tuple2.Item5);
            Equals(tuple2, tuple3);
            
        }
    }
}