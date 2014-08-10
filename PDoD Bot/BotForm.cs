using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDoD_Bot
{
    public partial class BotForm : Form
    {
        private Changelog changeLog = new Changelog();
        private Targeting targeting = new Targeting();
        private Cavebot cavebot = new Cavebot();

        public static string NAME = "PDoD Bot";
        public static string VERSION = "v0.7";

        private List<Label> labelsSlotsNombres = new List<Label>();
        private List<Label> labelsSlotsLvl = new List<Label>();
        private List<Label> labelsSlotsExpTotal = new List<Label>();
        private List<Label> labelsSlotsHp = new List<Label>();
        private List<Label> labelsSlotsPP1 = new List<Label>();
        private List<Label> labelsSlotsPP2 = new List<Label>();
        private List<Label> labelsSlotsPP3 = new List<Label>();
        private List<Label> labelsSlotsPP4 = new List<Label>();
        private List<Panel> panelsSlots = new List<Panel>();

        public BotForm()
        {
            InitializeComponent();

            this.Text = BotForm.NAME + " " + BotForm.VERSION;

            changeLog.Visible = false;
            targeting.Visible = false;
            cavebot.Visible = false;

            #region Creamos listas de todo lo que se repite pa despues sea mas facil modificarlo
            labelsSlotsNombres.Add(label_slot1);
            labelsSlotsNombres.Add(label_slot2);
            labelsSlotsNombres.Add(label_slot3);
            labelsSlotsNombres.Add(label_slot4);
            labelsSlotsNombres.Add(label_slot5);
            labelsSlotsNombres.Add(label_slot6);

            labelsSlotsLvl.Add(label_slot1LVL);
            labelsSlotsLvl.Add(label_slot2LVL);
            labelsSlotsLvl.Add(label_slot3LVL);
            labelsSlotsLvl.Add(label_slot4LVL);
            labelsSlotsLvl.Add(label_slot5LVL);
            labelsSlotsLvl.Add(label_slot6LVL);

            labelsSlotsExpTotal.Add(label_slot1ExpTotal);
            labelsSlotsExpTotal.Add(label_slot2ExpTotal);
            labelsSlotsExpTotal.Add(label_slot3ExpTotal);
            labelsSlotsExpTotal.Add(label_slot4ExpTotal);
            labelsSlotsExpTotal.Add(label_slot5ExpTotal);
            labelsSlotsExpTotal.Add(label_slot6ExpTotal);

            labelsSlotsHp.Add(label_slot1HP);
            labelsSlotsHp.Add(label_slot2HP);
            labelsSlotsHp.Add(label_slot3HP);
            labelsSlotsHp.Add(label_slot4HP);
            labelsSlotsHp.Add(label_slot5HP);
            labelsSlotsHp.Add(label_slot6HP);

            labelsSlotsPP1.Add(label_slot1PP1);
            labelsSlotsPP1.Add(label_slot2PP1);
            labelsSlotsPP1.Add(label_slot3PP1);
            labelsSlotsPP1.Add(label_slot4PP1);
            labelsSlotsPP1.Add(label_slot5PP1);
            labelsSlotsPP1.Add(label_slot6PP1);

            labelsSlotsPP2.Add(label_slot1PP2);
            labelsSlotsPP2.Add(label_slot2PP2);
            labelsSlotsPP2.Add(label_slot3PP2);
            labelsSlotsPP2.Add(label_slot4PP2);
            labelsSlotsPP2.Add(label_slot5PP2);
            labelsSlotsPP2.Add(label_slot6PP2);

            labelsSlotsPP3.Add(label_slot1PP3);
            labelsSlotsPP3.Add(label_slot2PP3);
            labelsSlotsPP3.Add(label_slot3PP3);
            labelsSlotsPP3.Add(label_slot4PP3);
            labelsSlotsPP3.Add(label_slot5PP3);
            labelsSlotsPP3.Add(label_slot6PP3);

            labelsSlotsPP4.Add(label_slot1PP4);
            labelsSlotsPP4.Add(label_slot2PP4);
            labelsSlotsPP4.Add(label_slot3PP4);
            labelsSlotsPP4.Add(label_slot4PP4);
            labelsSlotsPP4.Add(label_slot5PP4);
            labelsSlotsPP4.Add(label_slot6PP4);

            panelsSlots.Add(panel_slot1);
            panelsSlots.Add(panel_slot2);
            panelsSlots.Add(panel_slot3);
            panelsSlots.Add(panel_slot4);
            panelsSlots.Add(panel_slot5);
            panelsSlots.Add(panel_slot6);

            MemoryHandler.loadAddresses();

            #endregion

            PokemonInfo.loadAllPokemons();
            BotUtils.initializeInput();            
        }

        private void timer_LeerValores_Tick(object sender, EventArgs e)
        {
            #region Arreglamos los string de lag
            if (AppConstants.KEY_DELAY == AppConstants.LAG_LOW)
            {
                if (!pocoToolStripMenuItem.Text.Contains(AppConstants.LAG_IDENTIFICADOR))
                    pocoToolStripMenuItem.Text = AppConstants.LAG_IDENTIFICADOR + pocoToolStripMenuItem.Text;
            }
            else
                pocoToolStripMenuItem.Text = pocoToolStripMenuItem.Text.Replace(AppConstants.LAG_IDENTIFICADOR, "");

            if (AppConstants.KEY_DELAY == AppConstants.LAG_MEDIUM)
            {
                if (!medioToolStripMenuItem.Text.Contains(AppConstants.LAG_IDENTIFICADOR))
                    medioToolStripMenuItem.Text = AppConstants.LAG_IDENTIFICADOR + medioToolStripMenuItem.Text;
            }
            else
                medioToolStripMenuItem.Text = medioToolStripMenuItem.Text.Replace(AppConstants.LAG_IDENTIFICADOR, "");

            if (AppConstants.KEY_DELAY == AppConstants.LAG_HIGH)
            {
                if (!altoToolStripMenuItem.Text.Contains(AppConstants.LAG_IDENTIFICADOR))
                    altoToolStripMenuItem.Text = AppConstants.LAG_IDENTIFICADOR + altoToolStripMenuItem.Text;
            }
            else
                altoToolStripMenuItem.Text = altoToolStripMenuItem.Text.Replace(AppConstants.LAG_IDENTIFICADOR, "");
            #endregion

            Process proc = MemoryHandler.getPokemonProcess();
            
            if (proc != null)
            {
                // Posicion
                label_position.Text = "Pos: (" + Player.getPosX().ToString() + ", " + Player.getPosY().ToString() + ")";
                label_money.Text = Player.getMoney().ToString() + " $";

                // Pelea            
                label_hpContrario.Text = "HP: " + Enemy.getHp().ToString();

                short idContrario = Enemy.getId();
                if (idContrario < 0)
                    idContrario = (short)AppConstants.NO_VALUE;

                string shiny = "";
                if (Enemy.isShiny())
                    shiny = "[SHINY] ";
                label_nombrePokemonContrario.Text = shiny + PokemonInfo.getPokemonName(idContrario);
                label_idContrario.Text = "ID: " + idContrario.ToString();

                #region Slots ...
                for (int i = 0; i < AppConstants.NUM_SLOTS; i++)
                {
                    string slotName = PokemonInfo.getPokemonName(Player.getPokemonId(i));
                    labelsSlotsNombres[i].Text = slotName;
                    if (slotName != "No Pokemon")
                    {
                        panelsSlots[i].Visible = true;
                        /*labelsSlotsLvl[i].Visible = true;
                        labelsSlotsExpTotal[i].Visible = true;
                        labelsSlotsHp[i].Visible = true;
                        labelsSlotsPP1[i].Visible = true;
                        labelsSlotsPP2[i].Visible = true;
                        labelsSlotsPP3[i].Visible = true;
                        labelsSlotsPP4[i].Visible = true;*/

                        labelsSlotsLvl[i].Text = "Lv: " + Player.getPokemonLvl(i).ToString();
                        labelsSlotsExpTotal[i].Text = "Exp: " + Player.getPokemonCurrentExp(i).ToString();
                        labelsSlotsPP1[i].Text = Player.getPP(i, AppConstants.PP_1).ToString();
                        labelsSlotsPP2[i].Text = Player.getPP(i, AppConstants.PP_2).ToString();
                        labelsSlotsPP3[i].Text = Player.getPP(i, AppConstants.PP_3).ToString();
                        labelsSlotsPP4[i].Text = Player.getPP(i, AppConstants.PP_4).ToString();
                    }
                    else
                    {
                        panelsSlots[i].Visible = false;
                        /*
                        labelsSlotsLvl[i].Visible = false;
                        labelsSlotsExpTotal[i].Visible = false;
                        labelsSlotsHp[i].Visible = false;
                        labelsSlotsPP1[i].Visible = false;
                        labelsSlotsPP2[i].Visible = false;
                        labelsSlotsPP3[i].Visible = false;
                        labelsSlotsPP4[i].Visible = false;
                        
                        labelsSlotsLvl[i].Text = "Lv: -1";
                        labelsSlotsExpTotal[i].Text = "Exp: -1";
                        labelsSlotsPP1[i].Text = "-1";
                        labelsSlotsPP2[i].Text = "-1";
                        labelsSlotsPP3[i].Text = "-1";
                        labelsSlotsPP4[i].Text = "-1";
                         */
                    }
                }
                #endregion
            }
            
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeLog.Visible = true;
        }

        private void targetingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            targeting.Visible = true;
        }

        private void cavebotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cavebot.Visible = true;
        }

        private void pocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConstants.KEY_DELAY = AppConstants.LAG_LOW;
        }

        private void medioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConstants.KEY_DELAY = AppConstants.LAG_MEDIUM;
        }

        private void altoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppConstants.KEY_DELAY = AppConstants.LAG_HIGH;
        }
    }
}
