using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRYSTAL_GAME
{
    internal class Afficher
    {

        public void dd(int x, int y, string c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        public void idd(int x, int y, int c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
        public void cdd(int x, int y, string c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.ReadKey();
            Console.Clear();

        }
        public void intRead(int i)
        {
            // i = Convert.ToUInt16(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out i);

        }
        public void floatRead(float i)
        {
            //i = Convert.ToUInt64(Console.ReadLine());
            float.TryParse(Console.ReadLine(), out i);
        }
    }
}
