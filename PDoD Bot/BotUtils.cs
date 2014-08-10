using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interceptor;

namespace PDoD_Bot
{
    class BotUtils
    {
        



        [DllImport("USER32.DLL", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        internal delegate int WindowEnumProc(IntPtr hwnd, IntPtr lparam);

        [DllImport("user32.dll")]
        internal static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc func, IntPtr lParam);

        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn,
            IntPtr lParam);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
 
        const uint WM_KEYDOWN = 0x0100;
        const uint WM_KEYUP = 0x0101;
        const uint WM_CHAR = 0x0102;

        public static Input input;

        public static void initializeInput()
        {
            input = new Input();

            // Be sure to set your keyboard filter to be able to capture key presses and simulate key presses
            // KeyboardFilterMode.All captures all events; 'Down' only captures presses for non-special keys; 'Up' only captures releases for non-special keys; 'E0' and 'E1' capture presses/releases for special keys
            input.KeyboardFilterMode = KeyboardFilterMode.All;
            // You can set a MouseFilterMode as well, but you don't need to set a MouseFilterMode to simulate mouse clicks

            // Finally, load the driver
            input.Load();

            input.KeyPressDelay = AppConstants.KEY_PRESSTIME;
        }

        public static void asdfmovie()
        {
            //SendInput();
        }

        public void sendKey(Interceptor.Keys key)
        {
            input.SendKeys(Interceptor.Keys.Enter);
            return;
            Process p = MemoryHandler.getPokemonProcess();
            if (p != null)
            {
                SetForegroundWindow(p.MainWindowHandle);
                
            }
        }

        public static void bringPokemonOnTop()
        {
            Process p = MemoryHandler.getPokemonProcess();
            if (p != null)
            {
                SetForegroundWindow(p.MainWindowHandle);
            }
        }               

        /* Todos los movimientos */
        public static void moveUp()
        {
            //bringPokemonOnTop();
            input.SendKeys(Interceptor.Keys.W);
        }

        public static void moveDown()
        {
            //bringPokemonOnTop();
            input.SendKeys(Interceptor.Keys.S);
        }

        public static void moveRight()
        {
            //bringPokemonOnTop();
            input.SendKeys(Interceptor.Keys.D);
        }

        public static void moveLeft()
        {
            //bringPokemonOnTop();
            input.SendKeys(Interceptor.Keys.A);
        }

        public static void walk(Waypoint wp)
        {
            /* Vemos si ya estamos encima */
            if (Player.getPosX() == wp.getX() && Player.getPosY() == wp.getY())
                return;

            /* Vemos hacia donde debemos ir */
            if (Player.getPosX() < wp.getX())
                moveRight();
            else if (Player.getPosX() > wp.getX())
                moveLeft();
            else if (Player.getPosY() < wp.getY())
                moveDown();
            else if (Player.getPosY() > wp.getY())
                moveUp();
        }

        public static void doAction()
        {
            //input.KeyPressDelay = AppConstants.KEY_DELAY;
            input.SendKeys(Interceptor.Keys.Space);
            //input.KeyPressDelay = AppConstants.KEY_PRESSTIME;
        }

        public static void setOption(int final)
        {
            int actual = GameMenu.getSelectedOption();

            while (final != actual && AppConstants.MENU_WAITING != MemoryHandler.getActualMenu())
            {
                actual = GameMenu.getSelectedOption();

                /* Mover derecha */
                if ((final == AppConstants.MENU_OPTION_2 || final == AppConstants.MENU_OPTION_4) &&
                    (actual == AppConstants.MENU_OPTION_1 || actual == AppConstants.MENU_OPTION_3))
                {
                    moveRight();
                    continue;
                }

                /* Mover izquierda */
                if ((final == AppConstants.MENU_OPTION_1 || final == AppConstants.MENU_OPTION_3) &&
                    (actual == AppConstants.MENU_OPTION_2 || actual == AppConstants.MENU_OPTION_4))
                {
                    moveLeft();
                    continue;
                }

                /* Mover abajo */
                if ((final == AppConstants.MENU_OPTION_3 || final == AppConstants.MENU_OPTION_4) &&
                    (actual == AppConstants.MENU_OPTION_1 || actual == AppConstants.MENU_OPTION_2))
                {
                    moveDown();
                    continue;
                }

                /* Mover arriba */
                if ((final == AppConstants.MENU_OPTION_1 || final == AppConstants.MENU_OPTION_2) &&
                    (actual == AppConstants.MENU_OPTION_3 || actual == AppConstants.MENU_OPTION_4))
                {
                    moveUp();
                    continue;
                }
            }
        }

        public static void pressFight()
        {
            /* Ponemos el cursor encima */            
            setOption(1);

            /* Presionamos espacio */
            while (AppConstants.MENU_FIGHT == GameMenu.getActualMenu())            
                doAction();            
        }

        public static void pressAttack()
        {
            /* Presionamos espacio */
            while (AppConstants.MENU_PP == GameMenu.getActualMenu())
                doAction();
        }

        public static bool tengoPP(bool atk1, bool atk2, bool atk3, bool atk4)
        {
            int pp = 0;
            if (atk1)
                pp += Player.getPP(AppConstants.SLOT_1, AppConstants.PP_1);

            if (atk2)
                pp += Player.getPP(AppConstants.SLOT_1, AppConstants.PP_2);

            if (atk3)
                pp += Player.getPP(AppConstants.SLOT_1, AppConstants.PP_3);

            if (atk4)
                pp += Player.getPP(AppConstants.SLOT_1, AppConstants.PP_4);

            if (pp > 0)
                return true;
            else
                return false;
        }

        public static int getAtaqueAUsar(bool atk1, bool atk2, bool atk3, bool atk4)
        {
            /* Buscar Addr de los PP del pokemon en batalla... */
            if (atk1 && Player.getPP(AppConstants.SLOT_1, AppConstants.PP_1) > 0)
                return AppConstants.MENU_OPTION_1;
            else if (atk2 && Player.getPP(AppConstants.SLOT_1, AppConstants.PP_2) > 0)
                return AppConstants.MENU_OPTION_2;
            else if (atk3 && Player.getPP(AppConstants.SLOT_1, AppConstants.PP_3) > 0)
                return AppConstants.MENU_OPTION_3;
            else if (atk4 && Player.getPP(AppConstants.SLOT_1, AppConstants.PP_4) > 0)
                return AppConstants.MENU_OPTION_4;
            else
                return -1;
        }
    }
}
