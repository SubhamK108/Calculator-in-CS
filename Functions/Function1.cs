using System;

namespace Function1
{
    public class BasicOperations
    {
        private double a;
        private double b;

        public BasicOperations(double number1, double number2)
        {
            this.a = number1;
            this.b = number2;
        }

        public double GetAdd()
        {
            return (this.a + this.b);
        }
        public double GetDiff()
        {
            return (this.a - this.b);
        }
        public double GetProd() => (this.a * this.b);

        public double GetDiv() => (this.a / this.b);
    }
}