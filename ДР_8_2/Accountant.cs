using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_8_2
{
    internal class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker)
                return true;
            return false;
        }
    }
}
