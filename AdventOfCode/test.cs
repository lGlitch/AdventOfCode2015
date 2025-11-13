using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class test
    {
        public static void test1()
        {
            int Largeur = 1;
            int longueur = 2;
            int hauteur = 3;
            if (Largeur <= longueur && Largeur <= hauteur) {  Console.WriteLine("Largeur"); }
            if (longueur <= Largeur && longueur <= hauteur) {  Console.WriteLine("longueur"); }
            if (hauteur <= Largeur && hauteur <= longueur) {  Console.WriteLine("hauteur"); }
        }
    }
}
