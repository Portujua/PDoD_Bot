using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDoD_Bot
{
    class Player
    {
        public static int getPosX()
        {
            return MemoryHandler.getPosX();
        }

        public static int getPosY()
        {
            return MemoryHandler.getPosY();
        }

        public static bool estaPeleando()
        {
            return MemoryHandler.estaPeleando();
        }

        public static int getMoney()
        {
            return MemoryHandler.getMoney();
        }

        public static short getPP(int slot, int ppId)
        {
            return MemoryHandler.getPP(slot, ppId);
        }

        public static int getPokemonLvl(int slot)
        {
            return MemoryHandler.getPokemonLvl(slot);
        }

        public static short getPokemonId(int slot)
        {
            return MemoryHandler.getPokemonId(slot);
        }

        public static int getPokemonCurrentExp(int slot)
        {
            return MemoryHandler.getPokemonCurrentExp(slot);
        }
    }
}
