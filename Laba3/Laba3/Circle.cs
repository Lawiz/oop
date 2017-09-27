using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Laba3
{
    class Circle:System.Object
    {
        private int xr;
        public int xR {
            get
            {
                return xr;
            }
             set
            {
                try 
                    {
                        if (value < 0) throw new ArgumentOutOfRangeException();
                        xr = value;
                    }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("error!");
                }
            
            }

        }

        private int yr;
        public int yR
        {
            get {return yr;}
             set
            {
            try
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                yr = value;
            }
            catch (ArgumentOutOfRangeException)
            {
                    Console.WriteLine("error!"); 
                }
        }

    }


        private int r;
        public int R
        {
            get
            {
                return r;

            }
             set
            {

                try
                {
                    if (value < 0) throw new ArgumentOutOfRangeException();
                    r= value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("error!");
                }
            }

        }
    
        private int refNumber = 0;
        const double p = Math.PI;
        private static bool doINeedIsThis = false;
        private static int count = 1;
        readonly double idExemplar;
        //constructrs
        public Circle()
        {
            xR = 0;
            yR = 0;
            R = 0;

        }
        public Circle(int xRValue, int yRValue, int rValue)
        {
            xR = xRValue;
            yR = yRValue;
            R = rValue;
            idExemplar = (xRValue * yRValue * rValue) / 300;
            incrementCount();
        }
        static Circle()
        {
            doINeedIsThis = true;
            incrementCount();
        }
        public static int incrementCount()
        {
            return ++count;
        }


        //metods

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Circle p = obj as Circle;

            if ((System.Object)p == null)
                return false;

            return (xR == p.xR) && (yR == p.yR)&&(R==p.R);
        }
        public  bool Equals(Circle p)
        {
            if ((object)p == null)
                return false;
            return (xR == p.xR) && (yR == p.yR) && (R == p.R);

        }
        public override int GetHashCode()
        {
            return xR * yR * R;
        }


        public double circumference()
        {
            return 2 * p * R;
        }


        public double areaCircle()
        {
            return p * Math.Pow(R, 2);
        }


        public void refMetod(ref int numb)
        {
            refNumber = numb;
        }


        public void outMetod(out int numb)
        {
            numb = 10;
            refNumber = numb;
        }
        

            
    }
}
