using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doForWhile
{
    class Class1
    {
        public bool check(int[] array,int number)
        {
            bool val = false;
            int point = 0;
            for (int i = 0; i < 6; i++)
            {
                if (array[i] != number)
                {
                    point++;
                }
            }         

             return (point == 6)?!val:val;
        }
    }
}
