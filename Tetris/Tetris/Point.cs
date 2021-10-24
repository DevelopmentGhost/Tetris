using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public void PrintSymbol(int x, int y, char c)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
