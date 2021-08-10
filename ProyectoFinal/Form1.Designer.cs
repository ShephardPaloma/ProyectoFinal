namespace ProyectoFinal
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bIBLIOTECAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aUTORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITORIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lIBROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSTUDIANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIBROToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRESTAMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bIBLIOTECAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bIBLIOTECAToolStripMenuItem
            // 
            this.bIBLIOTECAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTORToolStripMenuItem,
            this.eDITORIALToolStripMenuItem,
            this.lIBROToolStripMenuItem,
            this.eSTUDIANTEToolStripMenuItem,
            this.lIBROToolStripMenuItem1,
            this.pRESTAMOToolStripMenuItem});
            this.bIBLIOTECAToolStripMenuItem.Name = "bIBLIOTECAToolStripMenuItem";
            this.bIBLIOTECAToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.bIBLIOTECAToolStripMenuItem.Text = "BIBLIOTECA";
            // 
            // aUTORToolStripMenuItem
            // 
            this.aUTORToolStripMenuItem.Name = "aUTORToolStripMenuItem";
            this.aUTORToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aUTORToolStripMenuItem.Text = "AUTOR";
            // 
            // eDITORIALToolStripMenuItem
            // 
            this.eDITORIALToolStripMenuItem.Name = "eDITORIALToolStripMenuItem";
            this.eDITORIALToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eDITORIALToolStripMenuItem.Text = "DEVOLUCION";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(736, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lIBROToolStripMenuItem
            // 
            this.lIBROToolStripMenuItem.Name = "lIBROToolStripMenuItem";
            this.lIBROToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lIBROToolStripMenuItem.Text = "EDITORIAL";
            this.lIBROToolStripMenuItem.Click += new System.EventHandler(this.lIBROToolStripMenuItem_Click);
            // 
            // eSTUDIANTEToolStripMenuItem
            // 
            this.eSTUDIANTEToolStripMenuItem.Name = "eSTUDIANTEToolStripMenuItem";
            this.eSTUDIANTEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eSTUDIANTEToolStripMenuItem.Text = "ESTUDIANTE";
            // 
            // lIBROToolStripMenuItem1
            // 
            this.lIBROToolStripMenuItem1.Name = "lIBROToolStripMenuItem1";
            this.lIBROToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.lIBROToolStripMenuItem1.Text = "LIBRO";
            // 
            // pRESTAMOToolStripMenuItem
            // 
            this.pRESTAMOToolStripMenuItem.Name = "pRESTAMOToolStripMenuItem";
            this.pRESTAMOToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pRESTAMOToolStripMenuItem.Text = "PRESTAMO";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 638);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bIBLIOTECAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aUTORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITORIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIBROToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem eSTUDIANTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIBROToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRESTAMOToolStripMenuItem;
    }
}

