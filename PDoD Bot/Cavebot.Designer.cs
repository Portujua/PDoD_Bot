namespace PDoD_Bot
{
    partial class Cavebot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cavebot));
            this.checkBox_Loop = new System.Windows.Forms.CheckBox();
            this.checkBox_EndLoop = new System.Windows.Forms.CheckBox();
            this.button_action = new System.Windows.Forms.Button();
            this.timer_walk = new System.Windows.Forms.Timer(this.components);
            this.checkBox_cavebot = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_waypoints = new System.Windows.Forms.ListView();
            this.columna_Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columna_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Direcciones = new System.Windows.Forms.ComboBox();
            this.button_caminar = new System.Windows.Forms.Button();
            this.button_puerta = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_Loop
            // 
            this.checkBox_Loop.AutoSize = true;
            this.checkBox_Loop.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Loop.Location = new System.Drawing.Point(153, 39);
            this.checkBox_Loop.Name = "checkBox_Loop";
            this.checkBox_Loop.Size = new System.Drawing.Size(50, 17);
            this.checkBox_Loop.TabIndex = 7;
            this.checkBox_Loop.Text = "Loop";
            this.checkBox_Loop.UseVisualStyleBackColor = true;
            this.checkBox_Loop.CheckStateChanged += new System.EventHandler(this.checkBox_Loop_CheckStateChanged);
            // 
            // checkBox_EndLoop
            // 
            this.checkBox_EndLoop.AutoSize = true;
            this.checkBox_EndLoop.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_EndLoop.Location = new System.Drawing.Point(205, 39);
            this.checkBox_EndLoop.Name = "checkBox_EndLoop";
            this.checkBox_EndLoop.Size = new System.Drawing.Size(74, 17);
            this.checkBox_EndLoop.TabIndex = 8;
            this.checkBox_EndLoop.Text = "End Loop";
            this.checkBox_EndLoop.UseVisualStyleBackColor = true;
            this.checkBox_EndLoop.CheckStateChanged += new System.EventHandler(this.checkBox_EndLoop_CheckStateChanged);
            // 
            // button_action
            // 
            this.button_action.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_action.Location = new System.Drawing.Point(153, 62);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(70, 23);
            this.button_action.TabIndex = 9;
            this.button_action.Text = "Accion";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // timer_walk
            // 
            this.timer_walk.Enabled = true;
            this.timer_walk.Tick += new System.EventHandler(this.timer_walk_Tick);
            // 
            // checkBox_cavebot
            // 
            this.checkBox_cavebot.AutoSize = true;
            this.checkBox_cavebot.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cavebot.Location = new System.Drawing.Point(283, 39);
            this.checkBox_cavebot.Name = "checkBox_cavebot";
            this.checkBox_cavebot.Size = new System.Drawing.Size(92, 17);
            this.checkBox_cavebot.TabIndex = 10;
            this.checkBox_cavebot.Text = "AutoCaminar";
            this.checkBox_cavebot.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.waypointToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarScriptToolStripMenuItem,
            this.guardarScriptToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarScriptToolStripMenuItem
            // 
            this.cargarScriptToolStripMenuItem.Name = "cargarScriptToolStripMenuItem";
            this.cargarScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cargarScriptToolStripMenuItem.Text = "Abrir Script";
            this.cargarScriptToolStripMenuItem.Click += new System.EventHandler(this.cargarScriptToolStripMenuItem_Click);
            // 
            // guardarScriptToolStripMenuItem
            // 
            this.guardarScriptToolStripMenuItem.Name = "guardarScriptToolStripMenuItem";
            this.guardarScriptToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.guardarScriptToolStripMenuItem.Text = "Guardar Script";
            this.guardarScriptToolStripMenuItem.Click += new System.EventHandler(this.guardarScriptToolStripMenuItem_Click);
            // 
            // waypointToolStripMenuItem
            // 
            this.waypointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarTodosToolStripMenuItem});
            this.waypointToolStripMenuItem.Name = "waypointToolStripMenuItem";
            this.waypointToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.waypointToolStripMenuItem.Text = "Waypoint";
            // 
            // eliminarTodosToolStripMenuItem
            // 
            this.eliminarTodosToolStripMenuItem.Name = "eliminarTodosToolStripMenuItem";
            this.eliminarTodosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.eliminarTodosToolStripMenuItem.Text = "Eliminar Todos";
            this.eliminarTodosToolStripMenuItem.Click += new System.EventHandler(this.eliminarTodosToolStripMenuItem_Click);
            // 
            // listView_waypoints
            // 
            this.listView_waypoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columna_Tipo,
            this.columna_X,
            this.columna_Y});
            this.listView_waypoints.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_waypoints.Location = new System.Drawing.Point(12, 39);
            this.listView_waypoints.Name = "listView_waypoints";
            this.listView_waypoints.Size = new System.Drawing.Size(135, 256);
            this.listView_waypoints.TabIndex = 13;
            this.listView_waypoints.UseCompatibleStateImageBehavior = false;
            this.listView_waypoints.View = System.Windows.Forms.View.Details;
            // 
            // columna_Tipo
            // 
            this.columna_Tipo.Text = "Tipo";
            this.columna_Tipo.Width = 55;
            // 
            // columna_X
            // 
            this.columna_X.Text = "X";
            this.columna_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columna_X.Width = 30;
            // 
            // columna_Y
            // 
            this.columna_Y.Text = "Y";
            this.columna_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columna_Y.Width = 30;
            // 
            // comboBox_Direcciones
            // 
            this.comboBox_Direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Direcciones.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Direcciones.FormattingEnabled = true;
            this.comboBox_Direcciones.Items.AddRange(new object[] {
            "Centro",
            "Norte",
            "Sur",
            "Este",
            "Oeste"});
            this.comboBox_Direcciones.Location = new System.Drawing.Point(229, 62);
            this.comboBox_Direcciones.Name = "comboBox_Direcciones";
            this.comboBox_Direcciones.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Direcciones.TabIndex = 14;
            // 
            // button_caminar
            // 
            this.button_caminar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_caminar.Location = new System.Drawing.Point(153, 91);
            this.button_caminar.Name = "button_caminar";
            this.button_caminar.Size = new System.Drawing.Size(70, 23);
            this.button_caminar.TabIndex = 15;
            this.button_caminar.Text = "Caminar";
            this.button_caminar.UseVisualStyleBackColor = true;
            this.button_caminar.Click += new System.EventHandler(this.button_caminar_Click);
            // 
            // button_puerta
            // 
            this.button_puerta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_puerta.Location = new System.Drawing.Point(153, 120);
            this.button_puerta.Name = "button_puerta";
            this.button_puerta.Size = new System.Drawing.Size(70, 23);
            this.button_puerta.TabIndex = 16;
            this.button_puerta.Text = "Puerta";
            this.button_puerta.UseVisualStyleBackColor = true;
            this.button_puerta.Click += new System.EventHandler(this.button_puerta_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PDoD Bot files (*.pbe)|*.pbe";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PDoD Bot files (*.pbe)|*.pbe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lvl para parar el cavebot";
            // 
            // Cavebot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_puerta);
            this.Controls.Add(this.button_caminar);
            this.Controls.Add(this.comboBox_Direcciones);
            this.Controls.Add(this.listView_waypoints);
            this.Controls.Add(this.checkBox_cavebot);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.checkBox_EndLoop);
            this.Controls.Add(this.checkBox_Loop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Cavebot";
            this.Text = "Cavebot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cavebot_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cavebot_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Loop;
        private System.Windows.Forms.CheckBox checkBox_EndLoop;
        private System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Timer timer_walk;
        private System.Windows.Forms.CheckBox checkBox_cavebot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarScriptToolStripMenuItem;
        private System.Windows.Forms.ListView listView_waypoints;
        private System.Windows.Forms.ColumnHeader columna_Tipo;
        private System.Windows.Forms.ColumnHeader columna_X;
        private System.Windows.Forms.ColumnHeader columna_Y;
        private System.Windows.Forms.ToolStripMenuItem waypointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodosToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_Direcciones;
        private System.Windows.Forms.Button button_caminar;
        private System.Windows.Forms.Button button_puerta;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}