using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDoD_Bot
{
    class Enemy
    {
        public static int getHp()
        {
            return MemoryHandler.getEnemyHp();
        }

        public static short getId()
        {
            return MemoryHandler.getEnemyId();
        }

        public static bool isShiny()
        {
            return MemoryHandler.enemyIsShiny();
        }
    }
}
