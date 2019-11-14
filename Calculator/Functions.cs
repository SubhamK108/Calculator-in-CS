using System;

namespace Functions
{
    class BasicOperations
    {
        private decimal a;
        private decimal b;

        public BasicOperations(decimal number1, decimal number2)
        {
            this.a = number1;
            this.b = number2;
        }

        public decimal GetAdd()
        {
            return (this.a + this.b);
        }
    }
}