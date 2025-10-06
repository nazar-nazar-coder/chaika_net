using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.lab3
{
    public class Calculation_abc
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Calculation_abc() 
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public Calculation_abc(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Calculation_abc(Calculation_abc other) 
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
        }

        public double Calculate()
        {
            if (a > 15 && b > 15 && c > 15)
                return a * b * c;
            else
                return Math.Pow(a + b + c, 2);
        }

        public override string ToString()
        {
            return $"A = {a}, B = {b}, C = {c}, Result = {Calculate()}";
        }
    }
}
