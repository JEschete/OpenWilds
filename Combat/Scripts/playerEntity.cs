using System;

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

        public void setStat(int x, string y)
        {
            mainStats[y] = x;
        }

    }
}
