using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Personen
{
    class MainClass
    {

        public GObject[,] objects = new GObject[50, 50];

        public GObject[,] old = new GObject[50, 50];

        public Player player = new Player();

        public void run()
        {

            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    objects[x, y] = new Cube(ConsoleColor.White);
                }
            }

            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    if(x == 0 || x == 49)
                    {
                        objects[x, y] = new Cube(ConsoleColor.Cyan);
                    }

                    if(y == 0 || y == 49)
                    {
                        objects[x, y] = new Cube(ConsoleColor.Cyan);
                    }
                }
            }

            for (int y = 0; y < 50; y++)
            {
                for (int x = 24; x < 27; x++)
                {
                    objects[x, y] = new Cube(ConsoleColor.DarkGreen);
                }
            }

            while (player.alive)
            {
                player.handleKey(this, Console.ReadKey());
                draw();
            }

            gameOver();           

            Thread.Sleep(-1);
        }

        public void gameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 25);
            Char[] message = "[ You died... ]".ToCharArray();

            for(int i = 0; i < message.Count(); i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(150);
            }

            Console.SetCursorPosition(0, 0);

            Thread.Sleep(3000);
            Environment.Exit(0);
        }

        public void draw()
        {
            
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    if(old[x, y] == objects[x, y])
                    {
                        continue;
                    }

                    objects[x, y].drawObject(x, y);
                }
            }
            player.drawObject( player.x, player.y);
        
            old = (GObject[,]) objects.Clone();
        }


    }
}
