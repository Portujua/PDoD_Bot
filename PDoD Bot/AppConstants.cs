using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDoD_Bot
{
    class AppConstants
    {
        public const int SQM_SIZE = 32;

        public const int MENU_WAITING = 0;
        public const int MENU_FIGHT = 1;
        public const int MENU_PP = 2;
        public const int MENU_OPTION_1 = 1;
        public const int MENU_OPTION_2 = 2;
        public const int MENU_OPTION_3 = 3;
        public const int MENU_OPTION_4 = 4;

        public const int LAG_LOW = 150;
        public const int LAG_MEDIUM = 250;
        public const int LAG_HIGH = 400;
        public const string LAG_IDENTIFICADOR = "[x] ";

        public static int KEY_DELAY = LAG_MEDIUM;
        public const int KEY_PRESSTIME = 30;

        public const int NO_VALUE = -1;
        public const int NUM_SLOTS = 6;
        public const int NUM_PPS = 4;
        public const int SLOT_1 = 0;
        public const int SLOT_2 = 1;
        public const int SLOT_3 = 2;
        public const int SLOT_4 = 3;
        public const int SLOT_5 = 4;
        public const int SLOT_6 = 5;
        public const int PP_1 = 0;
        public const int PP_2 = 1;
        public const int PP_3 = 2;
        public const int PP_4 = 3;

        public const int WAYPOINT_CENTER = 0;
        public const int WAYPOINT_NORTH = 1;
        public const int WAYPOINT_SOUTH = 2;
        public const int WAYPOINT_EAST = 3;
        public const int WAYPOINT_WEST = 4;
        public const int WAYPOINT_NORMAL = 0;
        public const int WAYPOINT_LOOP = 1;
        public const int WAYPOINT_ENDLOOP = 2;
        public const int WAYPOINT_ACTION = 3;
        public const int WAYPOINT_DOOR = 4;
        public static int WAYPOINT_LAST_ID = 0;

        public static bool FIGHT_PP1 = false;
        public static bool FIGHT_PP2 = false;
        public static bool FIGHT_PP3 = false;
        public static bool FIGHT_PP4 = false;

        public const string FILE_EXTENSION = ".pbe";
        public const string FILE_DEFAULT_NAME = "miScript";

        public const string FOLDER_HISTORIAL = "Historial de Peleas";
        public const string FOLDER_SCRIPTS = "Scripts";

        public const int IV_HP = 1;
        public const int IV_ATTACK = 2;
        public const int IV_DEFENCE = 3;
        public const int IV_SPATTACK = 4;
        public const int IV_SPDEFENCE = 5;
        public const int IV_SPEED = 6;
                
    }
}
