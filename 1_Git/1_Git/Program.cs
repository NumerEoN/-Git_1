using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            River objRiver = new River();
            objRiver.SetInfo();
            objRiver.GetInfo();
            Console.ReadKey();
        }
    }
}
