using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba3
{
    class Laba3:Circle
    {
        public static void Main()
        {

        
       
            Circle newC1 = new Circle(2, 3, 4);
            Console.Write(newC1.R);
            Console.Write(newC1.xR);
            Console.Write(newC1.yR);

            Circle newC2 = new Circle();
            Console.WriteLine("Длинна окружности=" + newC1.circumference());
            Console.WriteLine("площадь круга=" + newC1.areaCircle());
            Console.WriteLine(newC2.R);
            Console.WriteLine(newC2.xR);
            Console.WriteLine(newC2.yR);

            if (newC1.Equals(newC2))
                Console.WriteLine("равны");
            else
                Console.WriteLine(" не равны");

            newC2.GetType();

           
            
            Circle[] listOfCircles = new Circle[5];
            
            Random rnd = new Random();
            for(int i=0; i<4;i++)
            {
                listOfCircles[i] = new Circle();
                listOfCircles[i].xR = rnd.Next();
                listOfCircles[i].yR = rnd.Next(0,4);
                listOfCircles[i].R = rnd.Next(0,4);

            }
            double[] arr = new double[4];
            for(int i = 0; i < 4; i++)
            {
                arr[i] = listOfCircles[i].areaCircle();
            }
            double min = 999999;
            double max = 0;
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            

                int[] repetCircleX = new int[5];
            int[] repetCircleY = new int[5];
            for(int i = 0; i < 3; i++)
            {
                if (listOfCircles[i].xR == listOfCircles[i++].xR) 
                    repetCircleX[i] = i;
                if (listOfCircles[i].yR==listOfCircles[i++].yR) 
                    repetCircleY[i] = i;

            }
            
            Console.WriteLine("по Х лежат на одной прямой окружности номер:");
            int count = 0;
            for(int i=0;i<3;i++)
            {
                Console.Write(repetCircleX[i] + ",");
                count++;
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(repetCircleX[i] + ",");
               
            }
            Console.WriteLine();
            var user = new { Name = "Tom", Age = 34 };
            Console.WriteLine(user.Name);
            Console.ReadKey(true);

        }

    }
}
