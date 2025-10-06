using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.lab3
{
    public class Calculation_ab
    {
        private int a;
        private int b;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public Calculation_ab()
        {
            a = 0;
            b = 0;
        }

        public Calculation_ab(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Calculation_ab(Calculation_ab other)
        {
            this.a = other.a;
            this.b = other.b;
        }

        public long Calculate()
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            long product = 1;
            bool found = false;

            for (int i = a; i <= b; i++)
            {
                if (i % 14 == 0)
                {
                    product *= i;
                    found = true;
                }
            }

            return found ? product : 0;
        }

        public override string ToString()
        {
            return $"A = {a}, B = {b}, Result = {Calculate()}";
        }
    }
}
