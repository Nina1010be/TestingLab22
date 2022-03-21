using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab2.MathMod;

namespace lab2
{
    public static class SystemFunction
    {
        public static double Calculate(double x)
        {
            if (x <= 0)
            {
                return Power(   (Power(Sin(x),3) + (Csc(x) + Sin(x))) / Sin(x) / Sin(x), 2);
            }
            else
            {
                return Power(((Power((Log(x, 2) * Ln(x)), 5)) + (Log(x, 2) * Ln(x))), 3) / Power(Math.Log(x), 2);
            }
        }
        public static double CalculateByDefaultMethods(double x)
        {
            if (x <= 0)
            {
                 
                return Math.Pow(   ((Math.Pow(Math.Sin(x),3) +  (MathCsc(x)+ Math.Sin(x))) / Math.Sin(x) /  Math.Sin(x)), 2);
            }
            else
            {
                return Math.Pow(((Math.Pow((Math.Log(x, 2) * Math.Log(x)),5)) +(Math.Log(x,2)* Math.Log(x))),3)/ Math.Pow(Math.Log(x), 2);

            }
        }
        private static double MathCot(double x)
        {
            return Math.Cos(x) / Math.Sin(x);
        }
        private static double MathCsc(double x)
        {
            return 1 / Math.Sin(x);
        }
    }
}
