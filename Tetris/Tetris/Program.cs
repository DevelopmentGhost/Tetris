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

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(Console.ReadLine());

            PrintSymbol(x, y, c);
            Console.ReadLine();
        }

        static void PrintSymbol(int x, int y, char c)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
