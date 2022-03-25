namespace OpenWildsCombat

{
    public class funcLib
    {

        // Take what you get generator

        public static List<int> StatAllocateGenerator()
        {
            int count = 0;
            List<int> statBank = new List<int> { 0, 0, 0, 0, 0, 0 };
            foreach (int i in statBank.ToList())
            {
                statBank[count] = statRoller();
                count++;
            }
            return statBank;

        }

        public static int statRoller()
        {
            List<int> rollTrack = new List<int> { 0, 0, 0 };
            int tempStat;
            int statSum = 0;
            Thread.Sleep(1);

            Random rand = new Random();
            for (int i = 0; i <= 3; i++)
            {
                tempStat = rand.Next(1, 7);
                if (tempStat > rollTrack.Min())
                {
                    int lowIndex = rollTrack.IndexOf(rollTrack.Min());
                    rollTrack[lowIndex] = tempStat;
                }
            }

            statSum = rollTrack.Sum();
            return statSum;
        }

        public static playerEntity BuildPlayer()
        {
            playerEntity player = new playerEntity();
            player.mainStats.Add("str", 0);
            player.mainStats.Add("dex", 0);
            player.mainStats.Add("con", 0);
            player.mainStats.Add("intel", 0);
            player.mainStats.Add("wis", 0);
            player.mainStats.Add("cha", 0);

            player.SetName();
            List<int> statArr = StatAllocateGenerator();
            statDistro(statArr, player);

            return player;
        }

        public static void statDistro(List<int> arr, playerEntity player)
        {

            List<int> remainingStats = arr;
            List<string> stats = new List<string> { "Strength", "Dexterity", "Constitution", "Intellect", "Wisdom", "Charisma" };
            string menuChoiceText;

            int menuState = 0;
            int menuChoiceNum = 0;
            int statChoice = 0;

            while (remainingStats.Count > 0)
            {
                switch (menuState)
                {
                    case 0:
                        Console.WriteLine("You have the following stat values left to allocate");
                        Console.WriteLine(String.Join(", ", remainingStats));
                        Console.WriteLine();
                        Console.WriteLine("Please choose an Attribute you would like to allocate stat points to by entering the menu number. ");

                        for (int i = 0; i < stats.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + stats[i]);
                        }

                        bool success = int.TryParse(Console.ReadLine(), out menuChoiceNum);
                        if (success == true)
                        {
                            if (menuChoiceNum > 0 & menuChoiceNum <= remainingStats.Count)
                            {
                                menuState = 1;
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please enter a valid choice. ");
                                menuState = 0;
                                break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid choice. ");
                            menuState = 0;
                            break;
                        }

                    case 1:
                        menuChoiceText = stats[(menuChoiceNum - 1)];
                        switch (menuChoiceText)
                        {
                            case "Strength":
                                bool allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Strength? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);
                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["str"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Strength");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            case "Dexterity":
                                allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Dexterity? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);
                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["dex"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Dexterity");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            case "Constitution":
                                allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Constitution? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);
                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["con"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Constitution");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            case "Intellect":
                                allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Intellect? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);

                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["intel"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Intellect");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            case "Wisdom":
                                allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Wisdom? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);
                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["wis"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Wisdom");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            case "Charisma":
                                allocated = false;
                                while (!allocated)
                                {
                                    if (statChoice == 0)
                                    {
                                        Console.WriteLine("Which Stat would you like to allocate to Charisma? ");
                                        Console.WriteLine(String.Join(", ", remainingStats));
                                        success = int.TryParse(Console.ReadLine(), out statChoice);
                                        if (success == false)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Please enter a valid choice. ");
                                            Console.WriteLine("");
                                        }
                                        else if (!remainingStats.Contains(statChoice))
                                        {
                                            Console.WriteLine("Please enter only a value from the list of stats");
                                            Console.WriteLine("Remaining stats: " + String.Join(", ", remainingStats));
                                            success = int.TryParse(Console.ReadLine(), out statChoice);
                                        }
                                        else
                                        {
                                            player.mainStats["cha"] = statChoice;
                                            remainingStats.Remove(statChoice);
                                            stats.Remove("Charisma");
                                            statChoice = 0;
                                            Console.Clear();
                                            menuState = 0;
                                            allocated = true;
                                            break;
                                        }
                                    }
                                }
                                menuState = 0;
                                break;

                            default:
                                statChoice = 0;
                                Console.Clear();
                                menuState = 0;
                                break;
                        }
                        menuState = 0;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid choice. ");
                        menuState = 0;
                        break;
                }
            }
        }
    }
}