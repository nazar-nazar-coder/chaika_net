using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.lab1
{
    internal class Tabul
    {
        public double[,] xy_array = new double[1000, 2];
        public int n = 0;

        // f1(x) = |x|^(2x+1)
        private double f1(double x)
        {
            try { return Math.Pow(Math.Abs(x), 2 * x + 1); }
            catch { return double.NaN; }
        }

        // f2(x) = sin(x^2)
        private double f2(double x)
        {
            return Math.Sin(x * x);
        }

        // f3(x) = ln^2(|x|) + sqrt(x), тільки для x > 0
        private double f3(double x)
        {
            if (x > 0)
                return Math.Pow(Math.Log(Math.Abs(x)), 2) + Math.Sqrt(x);
            else
                return double.NaN;
        }

        public void calculate(double xn = -4.41, double xk = 11.25, double h = 0.6, double a = 2.0)
        {
            double x = xn;
            int i = 0;

            while (x <= xk && i < 1000)
            {
                double y;

                if (x <= 0)
                {
                    y = f1(x);
                }
                else if (x > 0 && x <= a)
                {
                    y = f2(x);
                }
                else
                {
                    y = f3(x);
                }

                xy_array[i, 0] = x;
                xy_array[i, 1] = y;

                i++;
                x += h;
            }

            n = i;
        }
    }
}
