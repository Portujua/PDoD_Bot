using PDoD_Bot.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDoD_Bot
{
    public partial class Targeting : Form
    {
        private bool estaOcupado = false;
        private bool guardarHistorial = false;
        private bool debeAnadir = false;

        private void anadirAlHistorial()
        {
            string fecha = DateTime.Now.Date.Day.ToString() + "-" + DateTime.Now.Date.Month.ToString() + "-" + DateTime.Now.Date.Year.ToString();
            string ext = ".txt";
            string filename = AppConstants.FOLDER_HISTORIAL + "/" + fecha + ext;

            string archivoActual = "";

            if (File.Exists(filename))
            {
                
                try
                {
                    StreamReader sr = new StreamReader(filename);
                    archivoActual += sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception e)
                {
                }
                
            }

            string shiny = "";
            if (Enemy.isShiny())
                shiny = "[SHINY] ";
            archivoActual += Environment.NewLine + "[" + fecha + "] " + shiny + PokemonInfo.getPokemonName(Enemy.getId());

            try
            {
                System.IO.File.WriteAllText(@filename, archivoActual);
            }
            catch (Exception ex) { }
        }

        private void atacar()
        {
            estaOcupado = true;

            if (guardarHistorial && debeAnadir)
            {
                debeAnadir = false;
                anadirAlHistorial();
            }

            while (Enemy.getHp() > 0)
            {
                /* Espacio */
                BotUtils.pressFight();
                Thread.Sleep(AppConstants.KEY_DELAY); 

                /* Buscamos el ataque a usar y lo ponemos */
                int ataqueAUsar = BotUtils.getAtaqueAUsar(checkBox1.Checked, checkBox2.Checked,
                    checkBox3.Checked, checkBox4.Checked);

                BotUtils.setOption(ataqueAUsar);
                Thread.Sleep(AppConstants.KEY_DELAY); 

                /* Espacio */
                BotUtils.pressAttack();
                Thread.Sleep(AppConstants.KEY_DELAY); 
            }

            estaOcupado = false;
        }

        private void salirDeLaPelea()
        {
            estaOcupado = true;

            BotUtils.setOption(4);
            Thread.Sleep(AppConstants.KEY_DELAY); 
            BotUtils.doAction();
            Thread.Sleep(AppConstants.KEY_DELAY);

            estaOcupado = false;
        }

        public Targeting()
        {
            InitializeComponent();

            timerAtacar.Interval = AppConstants.KEY_DELAY;

            linkLabel_dondeEsta.Links.Add(0, 0, "http://forum.pdod.net/view/index.php?topic=10919.0");
            linkLabel_EV.Links.Add(0, 0, "http://forum.pdod.net/view/index.php?topic=14934.0");
        }

        private void Targeting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;
            else if (e.CloseReason == CloseReason.ApplicationExitCall)
                return;
            else
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void Targeting_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void timerAtacar_Tick(object sender, EventArgs e)
        {
            if (!checkBox_targeting.Checked) return;

            timerAtacar.Enabled = false;

            /* Actualizamos los valores de los checkbox pa poder usarlos en el cavebot */
            AppConstants.FIGHT_PP1 = checkBox1.Checked;
            AppConstants.FIGHT_PP2 = checkBox2.Checked;
            AppConstants.FIGHT_PP3 = checkBox3.Checked;
            AppConstants.FIGHT_PP4 = checkBox4.Checked;

            if (Player.estaPeleando())
            {
                short idContrario = Enemy.getId();
                Thread t;

                if (!estaOcupado)
                {
                    guardarHistorial = checkBox_historialPeleas.Checked;

                    #region Vemos si debo atacar
                    bool debeAtacar = false;

                    if (checkBox_noMatarShiny.Checked && Enemy.isShiny())
                    {
                        if (checkBox_alarmaShiny.Checked)
                        {
                            try
                            {
                                SoundPlayer player = new SoundPlayer(Resources.alert);
                                player.Play();
                            }
                            catch (Exception ex) { }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < listView_targets.Items.Count; i++)
                        {
                            string actual = listView_targets.Items[i].Text.ToUpper();
                            if (actual == PokemonInfo.getPokemonName(idContrario).ToUpper())
                            {
                                debeAtacar = true;
                                break;
                            }
                            else if (actual == "TODOS" || actual == "ALL" || actual == "TODO")
                            {
                                debeAtacar = true;
                                break;
                            }
                        }
                    }
                    #endregion

                    if (BotUtils.tengoPP(checkBox1.Checked, checkBox2.Checked,
                    checkBox3.Checked, checkBox4.Checked))
                    {
                        if (debeAtacar)
                        {
                            t = new Thread(atacar);
                            t.Start();
                        }
                        else if (checkBox_correrleAlResto.Checked)
                        {
                            t = new Thread(salirDeLaPelea);
                            t.Start();
                        }
                        else if (checkBox_alarmaPoemonEspecial.Checked)
                        {
                            try
                            {
                                SoundPlayer player = new SoundPlayer(Resources.alert);
                                player.Play();
                            }
                            catch (Exception ex) { }
                        }
                    }
                    else /* Salir de la pelea si no tengo pp */
                    {
                        t = new Thread(salirDeLaPelea);
                        t.Start();
                    }
                }
            }

            if (!Player.estaPeleando())
                debeAnadir = true;

            timerAtacar.Enabled = true;
        }

        private void linkLabel_dondeEsta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.pdod.net/view/index.php?topic=10919.0");
        }

        private void linkLabel_EV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://forum.pdod.net/view/index.php?topic=14934.0");
        }

        private void añadirPokemonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("NombrePokemon");
            listView_targets.Items.Add(lvi);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView_targets.Items.Remove(listView_targets.Items[listView_targets.FocusedItem.Index]);
            }
            catch (Exception ex) { }
        }
    }
}
