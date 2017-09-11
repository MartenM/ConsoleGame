using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    class Player : GObject
    {
        public int x = 25;
        public int y = 25;

        public Boolean alive = true;

        public void drawObject(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("█");
        }

        public void handleKey(MainClass plugin, ConsoleKeyInfo key)
        {          

            plugin.objects[x, y].drawObject(x, y);
            try
            {
                plugin.objects[x + 1, y].drawObject(x + 1, y);

            } catch(Exception ex)
            {

            }
            

            if (key.Key == ConsoleKey.A)
            {
                x -= 1;
            } else if(key.Key == ConsoleKey.D)
            {
                x += 1;
            } else if(key.Key == ConsoleKey.W)
            {
                y -= 1;
            }
            else if(key.Key == ConsoleKey.S)
            {
                y += 1;
            }

            if(x <= 49 && x >= 0 && y <= 49 && y >= 0)
            {

            }
            else
            {
                alive = false;     
                x = 25;
                y = 25;
            }
        }


    }
}
