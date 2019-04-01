using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Git
{
    class River
    {
        public string name { get; set; }
        public double area { get; set; }
        public double extension { get; set; }
        public River()
        {
            name = "";
            area = 0;
            extension = 0;
        }
        public void SetInfo()
        {
            Console.WriteLine("Ввод инфо о реке: ");
            Console.Write("название: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("площадь: ");
            area = Convert.ToDouble(Console.ReadLine());
            Console.Write("протяженность: ");
            extension = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public void GetInfo()
        {
            Console.WriteLine($"название: {name}");
            Console.WriteLine($"площадь: {area}");
            Console.WriteLine($"протяженность: {extension}");
        }
    }
}
