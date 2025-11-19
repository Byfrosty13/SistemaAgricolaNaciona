namespace Sistema_de_Venta_agricultura.Forms
{
    partial class Ubicaciones
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
            menuStrip1 = new MenuStrip();
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            registroProvedorToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            helpProvider1 = new HelpProvider();
            label2 = new Label();
            checkedListBoxProvincias = new CheckedListBox();
            CheckedListBoxCantones = new CheckedListBox();
            checkedListBoxDistritos = new CheckedListBox();
            btnLimpiar = new Button();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GreenYellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ubicacionToolStripMenuItem, productosToolStripMenuItem, registroProvedorToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1000, 31);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // ubicacionToolStripMenuItem
            // 
            ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            ubicacionToolStripMenuItem.Size = new Size(73, 29);
            ubicacionToolStripMenuItem.Text = "Inicio";
            ubicacionToolStripMenuItem.Click += ubicacionToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(113, 29);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 100);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 12;
            label2.Text = "Ubicacion";
            // 
            // checkedListBoxProvincias
            // 
            checkedListBoxProvincias.FormattingEnabled = true;
            checkedListBoxProvincias.Items.AddRange(new object[] { "" });
            checkedListBoxProvincias.Location = new Point(62, 140);
            checkedListBoxProvincias.Name = "checkedListBoxProvincias";
            checkedListBoxProvincias.Size = new Size(120, 112);
            checkedListBoxProvincias.TabIndex = 13;
            checkedListBoxProvincias.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // CheckedListBoxCantones
            // 
            CheckedListBoxCantones.FormattingEnabled = true;
            CheckedListBoxCantones.Items.AddRange(new object[] { "" });
            CheckedListBoxCantones.Location = new Point(240, 140);
            CheckedListBoxCantones.Name = "CheckedListBoxCantones";
            CheckedListBoxCantones.Size = new Size(120, 112);
            CheckedListBoxCantones.TabIndex = 14;
            CheckedListBoxCantones.SelectedIndexChanged += CheckedListBoxCanton_SelectedIndexChanged;
            // 
            // checkedListBoxDistritos
            // 
            checkedListBoxDistritos.FormattingEnabled = true;
            checkedListBoxDistritos.Items.AddRange(new object[] { "" });
            checkedListBoxDistritos.Location = new Point(398, 140);
            checkedListBoxDistritos.Name = "checkedListBoxDistritos";
            checkedListBoxDistritos.Size = new Size(120, 112);
            checkedListBoxDistritos.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(135, 356);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(62, 29);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Ubicaciones
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 577);
            Controls.Add(btnLimpiar);
            Controls.Add(checkedListBoxDistritos);
            Controls.Add(CheckedListBoxCantones);
            Controls.Add(checkedListBoxProvincias);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Name = "Ubicaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ubicaciones";
            Load += Ubicaciones_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem registroProvedorToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private HelpProvider helpProvider1;
        private Label label2;
        private CheckedListBox checkedListBoxProvincias;
        private CheckedListBox CheckedListBoxCantones;
        private CheckedListBox checkedListBoxDistritos;
        private Button btnLimpiar;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}