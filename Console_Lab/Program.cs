using Forms_Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("HELLO WORLD, " + name);
            frmCh02 fm = new frmCh02();
            fm.method5();
            Console.ReadKey();
        }
    }
}
