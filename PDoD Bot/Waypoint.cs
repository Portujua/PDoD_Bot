using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDoD_Bot
{
    class Waypoint
    {
        private int x, y, type, id;

        public Waypoint(int x, int y, int type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.id = AppConstants.WAYPOINT_LAST_ID;
            AppConstants.WAYPOINT_LAST_ID++;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getType()
        {
            return type;
        }

        public int getId()
        {
            return id;
        }

        public string getTypeString()
        {
            string tipo = "";
            switch (type)
            {
                case AppConstants.WAYPOINT_NORMAL:
                    tipo = "Normal";
                    break;
                case AppConstants.WAYPOINT_LOOP:
                    tipo = "Loop";
                    break;
                case AppConstants.WAYPOINT_ENDLOOP:
                    tipo = "EndLoop";
                    break;
                case AppConstants.WAYPOINT_ACTION:
                    tipo = "Action";
                    break;
                case AppConstants.WAYPOINT_DOOR:
                    tipo = "Puerta";
                    break;
            }
            return tipo;
        }

        public string getWaypoint()
        {
            return getTypeString() + "(" + x + ", " + y + ")";
        }
    }
}
