namespace Sistema_de_Venta_agricultura
{
    partial class PagInicial
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
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            lbluser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            label1.Location = new Point(223, 95);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { provedoresToolStripMenuItem, ubicacionToolStripMenuItem, horariosToolStripMenuItem, productosToolStripMenuItem, registroProvedorToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1000, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // provedoresToolStripMenuItem
            // 
            provedoresToolStripMenuItem.Name = "provedoresToolStripMenuItem";
            provedoresToolStripMenuItem.Size = new Size(124, 29);
            provedoresToolStripMenuItem.Text = "Provedores";
            provedoresToolStripMenuItem.Click += provedoresToolStripMenuItem_Click;
            // 
            // ubicacionToolStripMenuItem
            // 
            ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            ubicacionToolStripMenuItem.Size = new Size(111, 29);
            ubicacionToolStripMenuItem.Text = "Ubicacion";
            ubicacionToolStripMenuItem.Click += ubicacionToolStripMenuItem_Click;
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
            registroProvedorToolStripMenuItem.Click += registroProvedorToolStripMenuItem_Click;
            // 
            // actualizarDatosDeCuentaToolStripMenuItem
            // 
            actualizarDatosDeCuentaToolStripMenuItem.Name = "actualizarDatosDeCuentaToolStripMenuItem";
            actualizarDatosDeCuentaToolStripMenuItem.Size = new Size(86, 29);
            actualizarDatosDeCuentaToolStripMenuItem.Text = "Cuenta";
            actualizarDatosDeCuentaToolStripMenuItem.Click += actualizarDatosDeCuentaToolStripMenuItem_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            lbluser.Location = new Point(358, 95);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(93, 22);
            lbluser.TabIndex = 2;
            lbluser.Text = "(Persona)";
            // 
            // PagInicial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1000, 577);
            Controls.Add(lbluser);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PagInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagInicial";
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
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private Label lbluser;
    }
}