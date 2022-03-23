

namespace OpenWildsCombat

{
   public class funcLib
    {

        // Take what you get generator
        public static void MeanStatGenerator(playerEntity player)
        {

            List<int> rollTrack = new List<int> {0,0,0};
            int[] stats = player.mainStats;
            int tempStat;
            int statSum;
            Random rand = new Random();
            int count = 0;

            foreach (int stat in stats)
            {
                statSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    tempStat = rand.Next(1, 7);
                    if (tempStat > rollTrack.Min())
                    {
                        int lowIndex = rollTrack.IndexOf(rollTrack.Min());
                        rollTrack[lowIndex] = tempStat;
                    }
                }

                statSum = rollTrack.Sum();
                player.mainStats.SetValue(statSum,count);
                count++;

            }
        }
    }
}