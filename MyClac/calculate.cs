using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClac
{
    class calculate
    {
        public double Add(double _x, int _y)
        {
            return _x + _y;
        }

        public double Minus(double _x, int _y)
        {
            return _x - _y;
        }

        public double Multiply(double _x, int _y)
        {
            return _x * _y;
        }

        public double Divide(double _x, int _y)
        {
            return _x / _y;
        }

        public double Mod(double _x, int _y)
        {
            return _x % _y;
        }

        /*public int Denominator(int _x) //  1/x
        {
            return 1/_x;
        }

        public double Pow(int _x, int _y) //  X^Y
        {
            return Math.Pow((double)_x,(double)_y);
        }

        public double Log(int _x)
        {
            return Math.Log((double)_x);
        }
        public double Sqt(int _x)
        {
            return Math.Sqrt((double)_x);
        }*/
    }
}
