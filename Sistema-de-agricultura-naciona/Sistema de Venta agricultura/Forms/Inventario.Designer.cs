namespace Sistema_de_Venta_agricultura.Forms
{
    partial class Inventario
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
            cboTipoProducto = new ComboBox();
            cboProductor = new ComboBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            btnGuardarProducto = new Button();
            menuStrip1 = new MenuStrip();
            ubicacionToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            carritoToolStripMenuItem = new ToolStripMenuItem();
            registroProvedorToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            helpProvider1 = new HelpProvider();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.Font = new Font("Baskerville Old Face", 14.25F);
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(109, 133);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(162, 30);
            cboTipoProducto.TabIndex = 0;
            // 
            // cboProductor
            // 
            cboProductor.Font = new Font("Baskerville Old Face", 14.25F);
            cboProductor.FormattingEnabled = true;
            cboProductor.Location = new Point(109, 203);
            cboProductor.Name = "cboProductor";
            cboProductor.Size = new Size(162, 30);
            cboProductor.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Baskerville Old Face", 14.25F);
            txtCodigo.Location = new Point(394, 152);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(141, 29);
            txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Baskerville Old Face", 14.25F);
            txtNombre.Location = new Point(394, 243);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 29);
            txtNombre.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Baskerville Old Face", 14.25F);
            txtCantidad.Location = new Point(394, 317);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(141, 29);
            txtCantidad.TabIndex = 4;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.Font = new Font("Baskerville Old Face", 14.25F);
            btnGuardarProducto.Location = new Point(130, 370);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(141, 36);
            btnGuardarProducto.TabIndex = 5;
            btnGuardarProducto.Text = "Guardar";
            btnGuardarProducto.UseVisualStyleBackColor = true;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GreenYellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ubicacionToolStripMenuItem, productosToolStripMenuItem, carritoToolStripMenuItem, registroProvedorToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1000, 31);
            menuStrip1.TabIndex = 20;
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
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click_1;
            // 
            // carritoToolStripMenuItem
            // 
            carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            carritoToolStripMenuItem.Size = new Size(86, 29);
            carritoToolStripMenuItem.Text = "Carrito";
            // 
            // registroProvedorToolStripMenuItem
            // 
            registroProvedorToolStripMenuItem.Name = "registroProvedorToolStripMenuItem";
            registroProvedorToolStripMenuItem.Size = new Size(182, 29);
            registroProvedorToolStripMenuItem.Text = "Registro provedor";
            // 
            // actualizarDatosDeCuentaToolStripMenuItem
            // 
            actualizarDatosDeCuentaToolStripMenuItem.Name = "actualizarDatosDeCuentaToolStripMenuItem";
            actualizarDatosDeCuentaToolStripMenuItem.Size = new Size(86, 29);
            actualizarDatosDeCuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 14.25F);
            label1.Location = new Point(109, 108);
            label1.Name = "label1";
            label1.Size = new Size(148, 22);
            label1.TabIndex = 21;
            label1.Text = "Tipo de Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F);
            label2.Location = new Point(109, 178);
            label2.Name = "label2";
            label2.Size = new Size(81, 22);
            label2.TabIndex = 22;
            label2.Text = "Prodcuto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 14.25F);
            label3.Location = new Point(394, 133);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 23;
            label3.Text = "Codigo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 14.25F);
            label4.Location = new Point(394, 218);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 24;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 14.25F);
            label5.Location = new Point(394, 299);
            label5.Name = "label5";
            label5.Size = new Size(79, 22);
            label5.TabIndex = 25;
            label5.Text = "Cantidad";
            // 
            // Inventario
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 577);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(btnGuardarProducto);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(cboProductor);
            Controls.Add(cboTipoProducto);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inventario";
            Load += Inventario_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipoProducto;
        private ComboBox cboProductor;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private Button btnGuardarProducto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem carritoToolStripMenuItem;
        private ToolStripMenuItem registroProvedorToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private HelpProvider helpProvider1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}