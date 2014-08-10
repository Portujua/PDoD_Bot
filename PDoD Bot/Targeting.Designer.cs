namespace PDoD_Bot
{
    partial class Targeting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Targeting));
            this.timerAtacar = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox_targeting = new System.Windows.Forms.CheckBox();
            this.linkLabel_dondeEsta = new System.Windows.Forms.LinkLabel();
            this.linkLabel_EV = new System.Windows.Forms.LinkLabel();
            this.checkBox_historialPeleas = new System.Windows.Forms.CheckBox();
            this.listView_targets = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.targetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_correrleAlResto = new System.Windows.Forms.CheckBox();
            this.checkBox_alarmaPoemonEspecial = new System.Windows.Forms.CheckBox();
            this.checkBox_alarmaShiny = new System.Windows.Forms.CheckBox();
            this.checkBox_noMatarShiny = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAtacar
            // 
            this.timerAtacar.Enabled = true;
            this.timerAtacar.Tick += new System.EventHandler(this.timerAtacar_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(130, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(168, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(206, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(244, 49);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox_targeting
            // 
            this.checkBox_targeting.AutoSize = true;
            this.checkBox_targeting.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_targeting.Location = new System.Drawing.Point(129, 179);
            this.checkBox_targeting.Name = "checkBox_targeting";
            this.checkBox_targeting.Size = new System.Drawing.Size(86, 17);
            this.checkBox_targeting.TabIndex = 8;
            this.checkBox_targeting.Text = "AutoAtacar";
            this.checkBox_targeting.UseVisualStyleBackColor = true;
            // 
            // linkLabel_dondeEsta
            // 
            this.linkLabel_dondeEsta.AutoSize = true;
            this.linkLabel_dondeEsta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_dondeEsta.Location = new System.Drawing.Point(3, 216);
            this.linkLabel_dondeEsta.Name = "linkLabel_dondeEsta";
            this.linkLabel_dondeEsta.Size = new System.Drawing.Size(245, 14);
            this.linkLabel_dondeEsta.TabIndex = 9;
            this.linkLabel_dondeEsta.TabStop = true;
            this.linkLabel_dondeEsta.Text = "¿Donde esta el pokemon que quiero?";
            this.linkLabel_dondeEsta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dondeEsta_LinkClicked);
            // 
            // linkLabel_EV
            // 
            this.linkLabel_EV.AutoSize = true;
            this.linkLabel_EV.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_EV.Location = new System.Drawing.Point(3, 199);
            this.linkLabel_EV.Name = "linkLabel_EV";
            this.linkLabel_EV.Size = new System.Drawing.Size(175, 14);
            this.linkLabel_EV.TabIndex = 10;
            this.linkLabel_EV.TabStop = true;
            this.linkLabel_EV.Text = "¿Que EV da cada Pokemon?";
            this.linkLabel_EV.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_EV_LinkClicked);
            // 
            // checkBox_historialPeleas
            // 
            this.checkBox_historialPeleas.AutoSize = true;
            this.checkBox_historialPeleas.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_historialPeleas.Location = new System.Drawing.Point(221, 179);
            this.checkBox_historialPeleas.Name = "checkBox_historialPeleas";
            this.checkBox_historialPeleas.Size = new System.Drawing.Size(128, 17);
            this.checkBox_historialPeleas.TabIndex = 11;
            this.checkBox_historialPeleas.Text = "Guardar Historial";
            this.checkBox_historialPeleas.UseVisualStyleBackColor = true;
            // 
            // listView_targets
            // 
            this.listView_targets.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_targets.LabelEdit = true;
            this.listView_targets.Location = new System.Drawing.Point(6, 49);
            this.listView_targets.Name = "listView_targets";
            this.listView_targets.Size = new System.Drawing.Size(117, 147);
            this.listView_targets.TabIndex = 13;
            this.listView_targets.UseCompatibleStateImageBehavior = false;
            this.listView_targets.View = System.Windows.Forms.View.List;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // targetingToolStripMenuItem
            // 
            this.targetingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPokemonToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.targetingToolStripMenuItem.Name = "targetingToolStripMenuItem";
            this.targetingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.targetingToolStripMenuItem.Text = "Targeting";
            // 
            // añadirPokemonToolStripMenuItem
            // 
            this.añadirPokemonToolStripMenuItem.Name = "añadirPokemonToolStripMenuItem";
            this.añadirPokemonToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.añadirPokemonToolStripMenuItem.Text = "Añadir";
            this.añadirPokemonToolStripMenuItem.Click += new System.EventHandler(this.añadirPokemonToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Atacar a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Poderes a usar";
            // 
            // checkBox_correrleAlResto
            // 
            this.checkBox_correrleAlResto.AutoSize = true;
            this.checkBox_correrleAlResto.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_correrleAlResto.Location = new System.Drawing.Point(129, 114);
            this.checkBox_correrleAlResto.Name = "checkBox_correrleAlResto";
            this.checkBox_correrleAlResto.Size = new System.Drawing.Size(128, 17);
            this.checkBox_correrleAlResto.TabIndex = 17;
            this.checkBox_correrleAlResto.Text = "Correrle al resto";
            this.checkBox_correrleAlResto.UseVisualStyleBackColor = true;
            // 
            // checkBox_alarmaPoemonEspecial
            // 
            this.checkBox_alarmaPoemonEspecial.AutoSize = true;
            this.checkBox_alarmaPoemonEspecial.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_alarmaPoemonEspecial.Location = new System.Drawing.Point(129, 160);
            this.checkBox_alarmaPoemonEspecial.Name = "checkBox_alarmaPoemonEspecial";
            this.checkBox_alarmaPoemonEspecial.Size = new System.Drawing.Size(170, 17);
            this.checkBox_alarmaPoemonEspecial.TabIndex = 18;
            this.checkBox_alarmaPoemonEspecial.Text = "Alarma Pokemon NoEnLista";
            this.checkBox_alarmaPoemonEspecial.UseVisualStyleBackColor = true;
            // 
            // checkBox_alarmaShiny
            // 
            this.checkBox_alarmaShiny.AutoSize = true;
            this.checkBox_alarmaShiny.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_alarmaShiny.Location = new System.Drawing.Point(244, 137);
            this.checkBox_alarmaShiny.Name = "checkBox_alarmaShiny";
            this.checkBox_alarmaShiny.Size = new System.Drawing.Size(98, 17);
            this.checkBox_alarmaShiny.TabIndex = 19;
            this.checkBox_alarmaShiny.Text = "Alarma Shiny";
            this.checkBox_alarmaShiny.UseVisualStyleBackColor = true;
            // 
            // checkBox_noMatarShiny
            // 
            this.checkBox_noMatarShiny.AutoSize = true;
            this.checkBox_noMatarShiny.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_noMatarShiny.Location = new System.Drawing.Point(130, 137);
            this.checkBox_noMatarShiny.Name = "checkBox_noMatarShiny";
            this.checkBox_noMatarShiny.Size = new System.Drawing.Size(110, 17);
            this.checkBox_noMatarShiny.TabIndex = 20;
            this.checkBox_noMatarShiny.Text = "No matar Shiny";
            this.checkBox_noMatarShiny.UseVisualStyleBackColor = true;
            // 
            // Targeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 240);
            this.Controls.Add(this.checkBox_noMatarShiny);
            this.Controls.Add(this.checkBox_alarmaShiny);
            this.Controls.Add(this.checkBox_alarmaPoemonEspecial);
            this.Controls.Add(this.checkBox_correrleAlResto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_targets);
            this.Controls.Add(this.checkBox_historialPeleas);
            this.Controls.Add(this.linkLabel_EV);
            this.Controls.Add(this.linkLabel_dondeEsta);
            this.Controls.Add(this.checkBox_targeting);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Targeting";
            this.Text = "Targeting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Targeting_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Targeting_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAtacar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox_targeting;
        private System.Windows.Forms.LinkLabel linkLabel_dondeEsta;
        private System.Windows.Forms.LinkLabel linkLabel_EV;
        private System.Windows.Forms.CheckBox checkBox_historialPeleas;
        private System.Windows.Forms.ListView listView_targets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem targetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPokemonToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_correrleAlResto;
        private System.Windows.Forms.CheckBox checkBox_alarmaPoemonEspecial;
        private System.Windows.Forms.CheckBox checkBox_alarmaShiny;
        private System.Windows.Forms.CheckBox checkBox_noMatarShiny;
    }
}