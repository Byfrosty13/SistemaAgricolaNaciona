namespace Sistema_de_Venta_agricultura.Forms
{
    partial class Productos
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
            carritoCompraToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            salriToolStripMenuItem = new ToolStripMenuItem();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            helpProvider1 = new HelpProvider();
            dgvProductos = new DataGridView();
            btnAgregarCarrito = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GreenYellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ubicacionToolStripMenuItem, productosToolStripMenuItem, carritoCompraToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem, salriToolStripMenuItem, inicioToolStripMenuItem });
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
            ubicacionToolStripMenuItem.Size = new Size(111, 29);
            ubicacionToolStripMenuItem.Text = "Ubicacion";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(112, 29);
            productosToolStripMenuItem.Text = "Inventario";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // carritoCompraToolStripMenuItem
            // 
            carritoCompraToolStripMenuItem.Name = "carritoCompraToolStripMenuItem";
            carritoCompraToolStripMenuItem.Size = new Size(165, 29);
            carritoCompraToolStripMenuItem.Text = "Carrito Compra";
            // 
            // actualizarDatosDeCuentaToolStripMenuItem
            // 
            actualizarDatosDeCuentaToolStripMenuItem.Name = "actualizarDatosDeCuentaToolStripMenuItem";
            actualizarDatosDeCuentaToolStripMenuItem.Size = new Size(86, 29);
            actualizarDatosDeCuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // salriToolStripMenuItem
            // 
            salriToolStripMenuItem.Name = "salriToolStripMenuItem";
            salriToolStripMenuItem.Size = new Size(62, 29);
            salriToolStripMenuItem.Text = "Salir";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(73, 29);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(114, 93);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(374, 217);
            dgvProductos.TabIndex = 12;
            dgvProductos.CellContentClick += DataGridView_CellContentClick;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(512, 314);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(75, 23);
            btnAgregarCarrito.TabIndex = 13;
            btnAgregarCarrito.Text = "Agregar";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // Productos
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 577);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(dgvProductos);
            Controls.Add(menuStrip1);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Productos_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem carritoCompraToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private ToolStripMenuItem salriToolStripMenuItem;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private HelpProvider helpProvider1;
        private DataGridView dgvProductos;
        private Button btnAgregarCarrito;
    }
}