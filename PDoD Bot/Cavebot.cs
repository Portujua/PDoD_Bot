using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDoD_Bot
{
    public partial class Cavebot : Form
    {
        private bool isWalking;

        private List<Waypoint> waypointList;
        private int nextWaypoint;

        #region Mis funciones

        private void saveFile(string path)
        {
            /* Estructura del archivo
             * x,y,tipo
             */
            string archivo = "";

            for (int i = 0; i < waypointList.Count; i++)
            {
                if (i > 0)
                    archivo += "\n";
                archivo += waypointList[i].getX() + "," + waypointList[i].getY() + "," + waypointList[i].getType();
            }

            System.IO.File.WriteAllText(@path, archivo);
        }

        private void loadFile(string path)
        {
            try
            {
                string[] lineas = System.IO.File.ReadAllLines(@path);
                waypointList = new List<Waypoint>();

                for (int i = 0; i < lineas.Length; i++)
                {
                    String[] info = lineas.ElementAt(i).Split(',');
                    waypointList.Add(new Waypoint(Convert.ToInt32(info[0]), Convert.ToInt32(info[1]), Convert.ToInt32(info[2])));
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando el script.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int getNextWaypointId()
        {
            if (nextWaypoint + 1 >= waypointList.Count)
                return 0;
            else
                return nextWaypoint + 1;
        }

        public void goToNextWaypoint()
        {
            if (waypointList.Count == 0) return;
            
            isWalking = true;
            int nextWaypointType = waypointList[nextWaypoint].getType();
            
            if (nextWaypointType == AppConstants.WAYPOINT_ACTION)
            {
                //int yInicial = Player.getPosY();
                //int yFinal = yInicial++; // Cuando haya bajado 1 sqm es pq termino de hablar
                
                while (MemoryHandler.getPosY() < 5) /* que balurdez */
                {
                    BotUtils.doAction();
                    Thread.Sleep(AppConstants.LAG_HIGH);
                    BotUtils.moveDown();
                    Thread.Sleep(AppConstants.LAG_HIGH);
                }
            }
            else
            {
                BotUtils.walk(waypointList[nextWaypoint]);
                /*BotUtils.moveRight();
                Thread.Sleep(AppConstants.KEY_DELAY);
                BotUtils.moveLeft();*/
                Thread.Sleep(AppConstants.KEY_DELAY);                
            }

            int prevType = nextWaypointType;

            if ((Player.getPosX() == waypointList[nextWaypoint].getX() &&
                Player.getPosY() == waypointList[nextWaypoint].getY()) ||
                nextWaypointType == AppConstants.WAYPOINT_ACTION ||
                nextWaypointType == AppConstants.WAYPOINT_DOOR)
                nextWaypoint = getNextWaypointId();
            
            /* Chequeo si era LOOP o ENDLOOP para modificar ...*/
            if (prevType == AppConstants.WAYPOINT_LOOP)
            {
                /* Chequeo PPs.. Si tengo, sigo normal.. Sino, mando al sig de endloop */
                if (!BotUtils.tengoPP(AppConstants.FIGHT_PP1, AppConstants.FIGHT_PP2,
                    AppConstants.FIGHT_PP3, AppConstants.FIGHT_PP4))
                {
                    /* Busco el que sigue despues de endloop */
                    for (int i = prevType; i < waypointList.Count; i++)
                        if (waypointList[i].getType() == AppConstants.WAYPOINT_ENDLOOP)
                        {
                            nextWaypoint = i + 1;
                            break;
                        }
                }
            }
            if (prevType == AppConstants.WAYPOINT_ENDLOOP)
            {
                /* Mando a LOOP */
                for (int i = 0; i < waypointList.Count; i++)
                    if (waypointList[i].getType() == AppConstants.WAYPOINT_LOOP)
                    {
                        nextWaypoint = i;
                        break;
                    }
            }
            
            isWalking = false;
        }

        private int getTipo(CheckBox loop, CheckBox endLoop)
        {
            if (loop.Checked)
                return AppConstants.WAYPOINT_LOOP;
            else if (endLoop.Checked)
                return AppConstants.WAYPOINT_ENDLOOP;
            else
                return AppConstants.WAYPOINT_NORMAL;
        }

        #endregion

        public Cavebot()
        {
            InitializeComponent();

            waypointList = new List<Waypoint>();
            nextWaypoint = 0;
            isWalking = false;

            timer_walk.Interval = AppConstants.KEY_DELAY;

            comboBox_Direcciones.SelectedIndex = 0;
        }

        private void Cavebot_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void Cavebot_FormClosing(object sender, FormClosingEventArgs e)
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

        private void checkBox_EndLoop_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Loop.Checked && checkBox_EndLoop.Checked)
            {
                MessageBox.Show("Error, no pueden estar ambos seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_Loop.Checked = false;
                checkBox_EndLoop.Checked = false;
            }
        }

        private void checkBox_Loop_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Loop.Checked && checkBox_EndLoop.Checked)
            {
                MessageBox.Show("Error, no pueden estar ambos seleccionados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox_Loop.Checked = false;
                checkBox_EndLoop.Checked = false;
            }
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            Waypoint nuevo = new Waypoint(Player.getPosX(), Player.getPosY(), AppConstants.WAYPOINT_ACTION);

            waypointList.Add(nuevo);

            ListViewItem lvi = new ListViewItem(nuevo.getTypeString());
            lvi.SubItems.Add(nuevo.getX().ToString());
            lvi.SubItems.Add(nuevo.getY().ToString());

            listView_waypoints.Items.Add(lvi);
        }

        private void timer_walk_Tick(object sender, EventArgs e)
        {
            if (!checkBox_cavebot.Checked) return;            
            try
            {
                /* Por nivel */
                if (Player.getPokemonLvl(AppConstants.SLOT_1) >= Convert.ToInt32(textBox1.Text)) return;

                /* Por exp */
                //if (Player.getPokemonCurrentExp(AppConstants.SLOT_1) >= Convert.ToInt32(textBox1.Text)) return;
            }
            catch (Exception ex) { }

            //label1.Text = "Ahora: " + waypointList[nextWaypoint].getWaypoint();            
            /* Marcamos el actual en la lista */
            //listView_waypoints.Items[nextWaypoint].Text = ">>>" + listView_waypoints.Items[nextWaypoint].Text;
            listView_waypoints.Items[nextWaypoint].ForeColor = Color.FromKnownColor(KnownColor.Red);
            /* Borramos el texto de todos los otros */
            for (int i = 0; i < listView_waypoints.Items.Count; i++)
                if (i != nextWaypoint)
                    //listView_waypoints.Items[i].Text = listView_waypoints.Items[i].Text.Replace(">>>", "");
                    listView_waypoints.Items[i].ForeColor = Color.FromKnownColor(KnownColor.Black);

            if (!isWalking && !MemoryHandler.estaPeleando())
            {
                Thread t = new Thread(goToNextWaypoint);
                t.Start();                
            }
        }

        private void guardarScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                saveFile(saveFileDialog.FileName);
            }
        }

        private void cargarScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                loadFile(openFileDialog.FileName);

                /* Añadimos los puntos a la listview */
                for (int i = 0; i < waypointList.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(waypointList[i].getTypeString());
                    lvi.SubItems.Add(waypointList[i].getX().ToString());
                    lvi.SubItems.Add(waypointList[i].getY().ToString());

                    listView_waypoints.Items.Add(lvi);
                }
            }
        }

        private void eliminarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar todos los waypoints?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                waypointList = new List<Waypoint>();
                listView_waypoints.Items.Clear();
                AppConstants.WAYPOINT_LAST_ID = 0;
            }
        }

        private void button_caminar_Click(object sender, EventArgs e)
        {
            int modx = 0;
            int mody = 0;

            switch (comboBox_Direcciones.SelectedIndex)
            {
                case AppConstants.WAYPOINT_NORTH:
                    mody = -1;
                    break;
                case AppConstants.WAYPOINT_SOUTH:
                    mody = 1;
                    break;
                case AppConstants.WAYPOINT_EAST:
                    modx = 1;
                    break;
                case AppConstants.WAYPOINT_WEST:
                    modx = -1;
                    break;
            }

            Waypoint nuevo = new Waypoint(Player.getPosX() + modx, Player.getPosY() + mody, getTipo(checkBox_Loop, checkBox_EndLoop));
            waypointList.Add(nuevo);

            ListViewItem lvi = new ListViewItem(nuevo.getTypeString());
            lvi.SubItems.Add(nuevo.getX().ToString());
            lvi.SubItems.Add(nuevo.getY().ToString());

            listView_waypoints.Items.Add(lvi);

        }

        private void button_puerta_Click(object sender, EventArgs e)
        {
            int modx = 0;
            int mody = 0;

            switch (comboBox_Direcciones.SelectedIndex)
            {
                case AppConstants.WAYPOINT_NORTH:
                    mody = -1;
                    break;
                case AppConstants.WAYPOINT_SOUTH:
                    mody = 1;
                    break;
                case AppConstants.WAYPOINT_EAST:
                    modx = 1;
                    break;
                case AppConstants.WAYPOINT_WEST:
                    modx = -1;
                    break;
            }

            Waypoint nuevo = new Waypoint(Player.getPosX() + modx, Player.getPosY() + mody, AppConstants.WAYPOINT_DOOR);
            waypointList.Add(nuevo);

            waypointList.Add(nuevo);

            ListViewItem lvi = new ListViewItem(nuevo.getTypeString());
            lvi.SubItems.Add(nuevo.getX().ToString());
            lvi.SubItems.Add(nuevo.getY().ToString());

            listView_waypoints.Items.Add(lvi);
        }
    }
}
