using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRYSTAL_GAME
{
    internal class Color
    {
        public void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        public void Cyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public void Black()
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public void DarkBlue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public void DarkCyan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        public void DarkGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void DarkMagenta()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
        }
        public void DarkRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public void DarkYellow()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public void ColorNormal()
        {
            Console.ResetColor();
        }
    }
}
