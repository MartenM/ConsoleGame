using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass main = new MainClass();
            main.run();

            throw new Exception("This is not supposed to happen.");
        }
    }
}
