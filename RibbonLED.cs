using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueColorConsole;

namespace _7_nuget
{
    internal class RibbonLED
    {
        public static int size = 10;
        public char[] parts = new char[size];
        public int[,] colors = new int[size, 3];
        public RibbonLED(int count)
        {
           size = count;
        }
    }
}
