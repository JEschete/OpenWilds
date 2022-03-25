namespace OpenWildsCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            playerEntity player1 = funcLib.BuildPlayer();

            Console.WriteLine();



            Console.WriteLine("Well met " + player1.GetName() + " welcome to the wilds. ");
            Console.WriteLine();
            Console.WriteLine(" It seems your available stats are as such: ");
            Console.WriteLine(" Str: " + player1.getStat("str"));
            Console.WriteLine(" Dex: " + player1.getStat("dex"));
            Console.WriteLine(" Con: " + player1.getStat("con"));
            Console.WriteLine(" Int: " + player1.getStat("intel"));
            Console.WriteLine(" Wis: " + player1.getStat("wis"));
            Console.WriteLine(" Cha: " + player1.getStat("cha"));

        }
    }
}
