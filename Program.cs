using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWildsCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            playerEntity player1 = new playerEntity();

            player1.SetName();
            Console.WriteLine();
            funcLib.MeanStatGenerator(player1);

            Console.WriteLine("Well met " + player1.GetName() + " welcome to the wilds. ");
            Console.ReadLine();
            Console.WriteLine(" It seems your stats are as such: ");
            Console.WriteLine(" Str: " + player1.getStat(0));
            Console.WriteLine(" Dex: " + player1.getStat(1));
            Console.WriteLine(" Con: " + player1.getStat(2));
            Console.WriteLine(" Int: " + player1.getStat(3));
            Console.WriteLine(" Wis: " + player1.getStat(4));
            Console.WriteLine(" Cha: " + player1.getStat(5));

        }
    }
}
