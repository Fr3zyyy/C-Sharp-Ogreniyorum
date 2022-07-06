using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Ogreniyorum
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal dolar = 17.1734m;
            decimal euro = 17.62155m;

            Console.Write("Dolar'dan Tl Ye Çevir : ");
            int dolartl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Euro'dan Tl Ye Çevir : ");

            int eurotl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dolar => Tl " + dolar * dolartl);
            Console.WriteLine("Euro => Tl " + euro * eurotl);

            Console.Read();
        }
    }
}
