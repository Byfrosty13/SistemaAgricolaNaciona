namespace Sistema_de_Venta_agricultura.Forms
{
    partial class CuentaUser
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            provedoresToolStripMenuItem = new ToolStripMenuItem();
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            horariosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            registroProvedorToolStripMenuItem = new ToolStripMenuItem();
            lbluser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            label1.Location = new Point(324, 86);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { provedoresToolStripMenuItem, ubicacionToolStripMenuItem, horariosToolStripMenuItem, productosToolStripMenuItem, registroProvedorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1000, 31);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // provedoresToolStripMenuItem
            // 
            provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            provedoresToolStripMenuItem.Size = new Size(73, 29);
            provedoresToolStripMenuItem.Text = "Inicio";
            // 
            // ubicacionToolStripMenuItem
            // 
            ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            ubicacionToolStripMenuItem.Size = new Size(111, 29);
            ubicacionToolStripMenuItem.Text = "Ubicacion";
            // 
            // horariosToolStripMenuItem
            // 
            horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            horariosToolStripMenuItem.Size = new Size(102, 29);
            horariosToolStripMenuItem.Text = "Horarios";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(113, 29);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // registroProvedorToolStripMenuItem
            // 
            registroProvedorToolStripMenuItem.Name = "registroProvedorToolStripMenuItem";
            registroProvedorToolStripMenuItem.Size = new Size(182, 29);
            registroProvedorToolStripMenuItem.Text = "Registro provedor";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            lbluser.Location = new Point(450, 86);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(93, 22);
            lbluser.TabIndex = 5;
            lbluser.Text = "(Persona)";
            // 
            // CuentaUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 577);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(lbluser);
            Name = "CuentaUser";
            Text = "CuentaUser";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem provedoresToolStripMenuItem;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem horariosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem registroProvedorToolStripMenuItem;
        private Label lbluser;
    }
}