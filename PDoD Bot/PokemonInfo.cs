using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDoD_Bot
{
    class PokemonInfo
    {
        public static List<String> allPokemons;

        public static void loadAllPokemons()
        {
            allPokemons = new List<String>();

            try
            {
                StreamReader sr = new StreamReader("pokemonList.txt");
                String line;

                while ((line = sr.ReadLine()) != null)                
                    allPokemons.Add(line.Replace(" ", ""));
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo encontrar la lista de pokemons.");                
            }

            //MessageBox.Show("Se leyeron: " + allPokemons.Count);
        }

        public static string getPokemonName(short id)
        {
            if (id - 1 < allPokemons.Count && id > 0)
                return allPokemons[id - 1];
            else
                return "No Pokemon";
        }
    }
}
