using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_8_1
{
    public static class Printer
    {
        public static void Print(string stroka, int color)
        {
            switch (color)
            {
                case 0:
                    color = (int)ColorEnum.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 1:
                    color = (int)ColorEnum.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    color = (int)ColorEnum.Yellow;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    color = (int)ColorEnum.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 4:
                    color = (int)ColorEnum.White;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 5:
                    color = (int)ColorEnum.Blue;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 6:
                    color = (int)ColorEnum.Black;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                default:
                    Console.WriteLine("Incorrect!");
                    break;
            }

            Console.WriteLine(stroka);
        }
    }
}
