using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 3;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            int x2 = 3;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);


            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
