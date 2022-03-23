using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWildsCombat
{
    public abstract class Entities
    {
        public string? name;
        public int size;
        public int armorClass;
        public int maxHP;                       // For NPCs HP = Challenge Rating x (Hit Dice + Constitution Modifier) 
        public int[] movement = new int[5];     // Movement consists of General Movement, Swimming, Burrowing, Climbing, Flying
        public int[] mainStats = new int[6];           // Stats consist of strength, dexterity, contitution, intelligence, wisdom, charisma
        public int[] modifiers = new int[6];
        public int[] savingThrows = new int[6];        // SavingThrow = Modifier + Proficiency



        /***
         *       _____      _   _                                  _    _____      _   _                
         *      / ____|    | | | |                                | |  / ____|    | | | |               
         *     | |  __  ___| |_| |_ ___ _ __ ___    __ _ _ __   __| | | (___   ___| |_| |_ ___ _ __ ___ 
         *     | | |_ |/ _ \ __| __/ _ \ '__/ __|  / _` | '_ \ / _` |  \___ \ / _ \ __| __/ _ \ '__/ __|
         *     | |__| |  __/ |_| ||  __/ |  \__ \ | (_| | | | | (_| |  ____) |  __/ |_| ||  __/ |  \__ \
         *      \_____|\___|\__|\__\___|_|  |___/  \__,_|_| |_|\__,_| |_____/ \___|\__|\__\___|_|  |___/
         *                                                                                              
         *                                                                                              
         */


    }
}
