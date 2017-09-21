using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Laba3
{
    class Circle
    {
        
        private int xR {
            get
            {
                return xR;
            }
            set
            {
                if (value > 0)
                    xR = value;
                else
                    xR = 0;
            }
        }
        
        private int yR
        {
            get
            {
                return yR;

            }
            set
            {
                if (value > 0)
                    yR = value;
                else
                    yR = 0;
            }
        }


        private int R
        {
            get
            {
                return R;

            }
            set
            {
                if (value > 0)
                    R = value;
                else
                    R = 0;
            }
        }
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
        public Circle (int xRValue, int yRValue, int rValue)
        {
            this.xR = xRValue;
            this.yR = yRValue;
            this.R = rValue;
            this.idExemplar = (xRValue * yRValue * rValue) / 300;
        }
        static Circle()
        {
            doINeedIsThis = true;
        }
        public static int incrementCount()
        {
            return ++count;
        }


        //metods
        public double circumference()
        {
            return 2 * p * R;
        }
         public double areaCircle()
        {
            return p * Math.Pow(R, 2);
        }
    }
}
