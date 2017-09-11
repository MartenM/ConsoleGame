using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    class Cube : GObject
    {
        public ConsoleColor colour;

        public Cube(ConsoleColor colour)
        {
            this.colour = colour;
        }

        public void drawObject(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = this.colour;
            Console.Write("█");
        }
    }
}
