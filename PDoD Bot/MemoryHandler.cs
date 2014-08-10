using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices; //USED TO CALL THE DLL IMPORTS
using System.Globalization;
using System.Diagnostics;
using System.Windows.Forms; //DELETE ME

namespace PDoD_Bot
{
    //Class wasnt done by me
    //FULL CREDITS TO
    //http://forum.cheatengine.org/viewtopic.php?t=530207


    public class MemoryHandler
    {     
        public static List<int[]> addressesPPS = new List<int[]>();

        /* ========================================= */
        /* ============== Direcciones ============== */
        /* ========================================= */

        public static int address_xPos = 0x00525808;
        public static int address_yPos = 0x0052580C;
        public static int address_money = 0x0052574C;

        public static int[] address_misPokemonsSlotsID = { 0x00525474, 0x005254EC, 0x00525564, 0x005255DC, 0x00525654, 0x005256CC };
        public static int[] address_misPokemonsLvl = { 0x005254D0, 0x00525548, 0x005255C0, 0x00525638, 0x005256B0, 0x00525728 };
        public static int[] address_slot1PP = { 0x005254A8, 0x005254A9, 0x005254AA, 0x005254AB };
        public static int[] address_slot2PP = { 0x00525520, 0x00525521, 0x00525522, 0x00525523 };
        public static int[] address_slot3PP = { 0x00525598, 0x00525599, 0x0052559A, 0x0052559B };
        public static int[] address_slot4PP = { 0x00525610, 0x00525611, 0x00525612, 0x00525613 };
        public static int[] address_slot5PP = { 0x00525688, 0x00525689, 0x0052568A, 0x0052568B };
        public static int[] address_slot6PP = { 0x00525700, 0x00525701, 0x00525702, 0x00525703 };

        public static int address_hpPokemonContrario = 0x0052513C;
        public static int address_idPokemonContrario = 0x00525130; // 0x00525130 o 0x00525FC4
        public static int address_contrarioEsShiny = 0x005251A0; // 0x005251A0 ... 0x00525FC0

        public static int address_menuOpcionSeleccion = 0x005252AA;
        public static int address_menuActual = 0x00525298;

        public static int address_estaEnPelea = 0x00532CF4;

        public static int[] address_iv_hp = { 0x00525496 };
        public static int[] address_iv_attack = { 0x00525492 };
        public static int[] address_iv_defensa = { 0x00525494 };
        public static int[] address_iv_spAttack = { 0x00525493 };
        public static int[] address_iv_spDefensa = { 0x00525495 };
        public static int[] address_iv_speed = { 0x00525497 };

        public static int[] address_currentExp = { 0x005254D4, 0x0052554C, 0x005255C4, 0x0052563C, 0x005256B4, 0x0052572C };


        /* ========================================= */
        /* ========================================= */
        /* ========================================= */


        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        public static Process getPokemonProcess()
        {
            Process[] plist = Process.GetProcessesByName("Pokemon Online");

            if (plist.Length > 0)
                return plist[0];
            else
                return null;
        }

        public static float readFloat(int dir)
        {
            Process process = getPokemonProcess();
            if (process == null) return 0;            

            int salida;
            byte[] value = MemoryHandler.ReadMemory(process, dir, sizeof(float), out salida);
            return BitConverter.ToSingle(value, 0);
        }

        public static int readInt(int dir)
        {
            Process process = getPokemonProcess();
            if (process == null) return 0;  

            int salida;
            byte[] value = MemoryHandler.ReadMemory(process, dir, sizeof(int), out salida);
                       
            return BitConverter.ToInt32(value, 0);
        }

        public static byte[] readByte(int dir)
        {
            Process process = getPokemonProcess();
            if (process == null) return null;  

            int salida;
            byte[] value = MemoryHandler.ReadMemory(process, dir, sizeof(int), out salida);
            return value;
        }

        public static short readShort(int dir)
        {
            Process process = getPokemonProcess();
            if (process == null) return 0;  

            int salida;
            byte[] value = MemoryHandler.ReadMemory(process, dir, sizeof(short), out salida);

            return BitConverter.ToInt16(value, 0);
        }

        public static byte[] ReadMemory(Process process, int address, int numOfBytes, out int bytesRead)
        {
            IntPtr hProc = OpenProcess(ProcessAccessFlags.All, false, process.Id);
            
            byte[] buffer = new byte[numOfBytes];

            ReadProcessMemory(hProc, new IntPtr(address), buffer, numOfBytes, out bytesRead);
            return buffer;
        }

        public static bool WriteMemory(Process process, int address, long value, out int bytesWritten)
        {
            IntPtr hProc = OpenProcess(ProcessAccessFlags.All, false, process.Id);

            byte[] val = BitConverter.GetBytes(value);

            bool worked = WriteProcessMemory(hProc, new IntPtr(address), val, (UInt32)val.LongLength, out bytesWritten);

            CloseHandle(hProc);

            return worked;
        }


        public static void writeByte(int dir, byte value)
        {
            Process process = getPokemonProcess();
            if (process == null) return;  

            int bytesEscritos;
            MemoryHandler.WriteMemory(process, dir, value, out bytesEscritos);
        }

        public static void writeInt(int dir, int value)
        {
            byte valorInt = Convert.ToByte(value);
            writeByte(dir, valorInt);
        }

        public static void writeFloat(int dir, float value)
        {
            byte valorFloat = Convert.ToByte(value);
            writeByte(dir, valorFloat);
        }


        public static void loadAddresses()
        {
            addressesPPS.Add(address_slot1PP);
            addressesPPS.Add(address_slot2PP);
            addressesPPS.Add(address_slot3PP);
            addressesPPS.Add(address_slot4PP);
            addressesPPS.Add(address_slot5PP);
            addressesPPS.Add(address_slot6PP);
        }



        public static bool estaPeleando()
        {
            return Convert.ToBoolean(readByte(address_estaEnPelea)[0]);         
        }

        public static int getPosX()
        {
            return Convert.ToInt32((readFloat(address_xPos) / AppConstants.SQM_SIZE));
        }

        public static int getPosY()
        {
            return Convert.ToInt32((readFloat(address_yPos) / AppConstants.SQM_SIZE));
        }

        public static int getEnemyHp()
        {
            return Convert.ToInt32(readFloat(address_hpPokemonContrario));
        }

        public static short getEnemyId()
        {
            return readShort(address_idPokemonContrario);
        }

        public static short getSelectedMenuOption()
        {
            return readByte(MemoryHandler.address_menuOpcionSeleccion)[0];
        }

        public static short getPP(int slot, int ppId)
        {
            return MemoryHandler.readByte(addressesPPS[slot][ppId])[0];
        }

        public static int getPokemonLvl(int slot)
        {
            return Convert.ToInt32(readInt(address_misPokemonsLvl[slot]));
        }

        public static short getPokemonId(int slot)
        {
            return readShort(address_misPokemonsSlotsID[slot]);
        }

        public static int getPokemonCurrentExp(int slot)
        {
            return readInt(address_currentExp[slot]);
        }

        public static int getActualMenu()
        {
            return Convert.ToInt32(readByte(address_menuActual)[0]);
        }

        public static bool enemyIsShiny()
        {
            return Convert.ToBoolean(readByte(address_contrarioEsShiny)[0]);
        }

        public static int getMoney()
        {
            return readInt(address_money);
        }

        public static int getMyPokemonsIV(int slot, int idIv)
        {
            switch (idIv)
            {
                case AppConstants.IV_HP:
                    return MemoryHandler.readByte(address_iv_hp[slot])[0];
                case AppConstants.IV_ATTACK:
                    return MemoryHandler.readByte(address_iv_attack[slot])[0];
                case AppConstants.IV_DEFENCE:
                    return MemoryHandler.readByte(address_iv_defensa[slot])[0];
                case AppConstants.IV_SPATTACK:
                    return MemoryHandler.readByte(address_iv_spAttack[slot])[0];
                case AppConstants.IV_SPDEFENCE:
                    return MemoryHandler.readByte(address_iv_spDefensa[slot])[0];
                case AppConstants.IV_SPEED:
                    return MemoryHandler.readByte(address_iv_speed[slot])[0];
            }

            return -1;
        }
    }
}