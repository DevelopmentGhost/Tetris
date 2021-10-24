using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30); // вказуємо розмір вікна
            Console.SetBufferSize(40, 30); //вказуємо для буферної області (прокрутка ховається за вікно консолі)

            
            Point p1 = new Point();
            p1.x = Convert.ToInt32(Console.ReadLine());
            p1.y = Convert.ToInt32(Console.ReadLine());
            p1.c = Convert.ToChar(Console.ReadLine());
            p1.PrintSymbol(p1.x, p1.y, p1.c);


            Point p2 = new Point();
            p2.x = Convert.ToInt32(Console.ReadLine());
            p2.y = Convert.ToInt32(Console.ReadLine());
            p2.c = Convert.ToChar(Console.ReadLine());
            p2.PrintSymbol(p2.x, p2.y, p2.c);
            Console.ReadLine();
        }

        
    }
}
