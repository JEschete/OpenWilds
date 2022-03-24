using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenWildsCombat
{
    public class playerEntity : Entities
    {
        int playerLevel;
        public string GetName()
        {
            return name;
        }
        public void SetName()
        {
            Console.WriteLine("Hello Adventure, what is your name ? ");
            name = Console.ReadLine();
            Console.WriteLine();

        }

        public int getStat(string i)
        {
            return mainStats[i];
        }

    }
}
