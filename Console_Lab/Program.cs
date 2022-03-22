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
        //static void Main(string[] args)
        //{
        //    Console.Write("Input your name: ");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("HELLO WORLD, " + name);
        //    frmCh02 fm = new frmCh02();
        //    fm.method5();
        //    Console.ReadKey();
        //}
        public class A
        {
            public string v;
            public string name;
            //A class被實例化時，會立即執行建構子內容，並且可以傳入參數
            public string Show
            {
                get { return name; }
                set
                {
                    name = v;
                    Console.WriteLine("I am " + value);
                }
            }
        }


        static void Main(string[] args)
        {
            //實例化A類別
            A x = new A();

            x.v = "Brown";
            x.Show = "Joe";
            Console.WriteLine(x.Show);
            Console.ReadLine();
        }

    }
}
