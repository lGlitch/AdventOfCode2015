using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Exo1
    {
        public static void Solution()
        {
            String Inupt = "";
            int nb = 0;
            foreach (var item in Inupt)
            {
                if (item == '(')
                {
                    nb += 1;
                }
                else { nb -= 1; }
            }
            Console.WriteLine(nb);
        }
    }
}
