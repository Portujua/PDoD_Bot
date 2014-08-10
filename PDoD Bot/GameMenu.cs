using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDoD_Bot
{
    class GameMenu
    {
        public static short getSelectedOption()
        {
            return MemoryHandler.getSelectedMenuOption();
        }

        public static int getActualMenu()
        {
            return MemoryHandler.getActualMenu();
        }
    }
}
