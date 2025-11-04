using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Calculator
    {
        private char sym;
        private double x;
        private double y;
        public Calculator(char sym, double x, double y) { 
            this.sym = sym;
            this.x = x;
            this.y = y;
        }

        public double Calculate ()
        {
            switch (this.sym) {
                case '+' : return this.x + this.y;
                case '-': return this.x - this.y;
                case '*': return this.x * this.y;
                case '/': return this.y != 0 ? this.x /this.y : 0;
                default: throw new NotImplementedException("Unsupported operand!");
            }
        }
    }
}
