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
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            horariosToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            carritoCompraToolStripMenuItem = new ToolStripMenuItem();
            registroProvedorToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            salriToolStripMenuItem = new ToolStripMenuItem();
            lbluser = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            helpProvider1 = new HelpProvider();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            label1.Location = new Point(282, 63);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GreenYellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ubicacionToolStripMenuItem, horariosToolStripMenuItem, productosToolStripMenuItem, carritoCompraToolStripMenuItem, registroProvedorToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem, salriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1000, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            horariosToolStripMenuItem.Click += horariosToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(113, 29);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // carritoCompraToolStripMenuItem
            // 
            carritoCompraToolStripMenuItem.Name = "carritoCompraToolStripMenuItem";
            carritoCompraToolStripMenuItem.Size = new Size(165, 29);
            carritoCompraToolStripMenuItem.Text = "Carrito Compra";
            carritoCompraToolStripMenuItem.Click += carritoCompraToolStripMenuItem_Click;
            // 
            // registroProvedorToolStripMenuItem
            // 
            registroProvedorToolStripMenuItem.Name = "registroProvedorToolStripMenuItem";
            registroProvedorToolStripMenuItem.Size = new Size(131, 29);
            registroProvedorToolStripMenuItem.Text = "Productores";
            registroProvedorToolStripMenuItem.Click += registroProvedorToolStripMenuItem_Click;
            // 
            // actualizarDatosDeCuentaToolStripMenuItem
            // 
            actualizarDatosDeCuentaToolStripMenuItem.Name = "actualizarDatosDeCuentaToolStripMenuItem";
            actualizarDatosDeCuentaToolStripMenuItem.Size = new Size(86, 29);
            actualizarDatosDeCuentaToolStripMenuItem.Text = "Cuenta";
            actualizarDatosDeCuentaToolStripMenuItem.Click += actualizarDatosDeCuentaToolStripMenuItem_Click;
            // 
            // salriToolStripMenuItem
            // 
            salriToolStripMenuItem.Name = "salriToolStripMenuItem";
            salriToolStripMenuItem.Size = new Size(62, 29);
            salriToolStripMenuItem.Text = "Salir";
            salriToolStripMenuItem.Click += salriToolStripMenuItem_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Bold);
            lbluser.Location = new Point(457, 63);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(93, 22);
            lbluser.TabIndex = 2;
            lbluser.Text = "(Persona)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(49, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 191);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 254);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 4;
            label2.Text = "Noticias Recientes";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(788, 542);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(742, 326);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(742, 295);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 7;
            label3.Text = "Futuras Ferias";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(49, 475);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(258, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tomate Sube un 15 descubra mas sobre el tema";
            // 
            // PagInicial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1000, 577);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(lbluser);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PagInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PagInicial";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem horariosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem registroProvedorToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private Label lbluser;
        private PictureBox pictureBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private HelpProvider helpProvider1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem carritoCompraToolStripMenuItem;
        private ToolStripMenuItem salriToolStripMenuItem;
    }
}