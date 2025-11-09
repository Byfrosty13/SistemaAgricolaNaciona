namespace Sistema_de_Venta_agricultura.Forms
{
    partial class RegistrarProvedores
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
            carritoToolStripMenuItem = new ToolStripMenuItem();
            registroProvedorToolStripMenuItem = new ToolStripMenuItem();
            actualizarDatosDeCuentaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            helpProvider1 = new HelpProvider();
            Cedula = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProductor = new TextBox();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.GreenYellow;
            menuStrip1.BackgroundImageLayout = ImageLayout.Center;
            menuStrip1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ubicacionToolStripMenuItem, productosToolStripMenuItem, carritoToolStripMenuItem, registroProvedorToolStripMenuItem, actualizarDatosDeCuentaToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(520, 31);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // ubicacionToolStripMenuItem
            // 
            ubicacionToolStripMenuItem.Name = "ubicacionToolStripMenuItem";
            ubicacionToolStripMenuItem.Size = new Size(73, 29);
            ubicacionToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(113, 29);
            productosToolStripMenuItem.Text = "Productos";
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
            registroProvedorToolStripMenuItem.Size = new Size(113, 29);
            registroProvedorToolStripMenuItem.Text = "Productor";
            // 
            // actualizarDatosDeCuentaToolStripMenuItem
            // 
            actualizarDatosDeCuentaToolStripMenuItem.Name = "actualizarDatosDeCuentaToolStripMenuItem";
            actualizarDatosDeCuentaToolStripMenuItem.Size = new Size(86, 29);
            actualizarDatosDeCuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 29);
            // 
            // Cedula
            // 
            Cedula.AutoSize = true;
            Cedula.Font = new Font("Baskerville Old Face", 14.25F);
            Cedula.Location = new Point(63, 127);
            Cedula.Name = "Cedula";
            Cedula.Size = new Size(110, 22);
            Cedula.TabIndex = 21;
            Cedula.Text = "Id Productor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 14.25F);
            label2.Location = new Point(63, 167);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 22;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 14.25F);
            label3.Location = new Point(63, 211);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 23;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 14.25F);
            label4.Location = new Point(63, 248);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 24;
            label4.Text = "Direccion";
            // 
            // txtProductor
            // 
            txtProductor.Font = new Font("Baskerville Old Face", 14.25F);
            txtProductor.Location = new Point(199, 120);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(258, 29);
            txtProductor.TabIndex = 25;
            txtProductor.TextChanged += txtProductor_TextChanged;
            txtProductor.KeyPress += txtProductor_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Baskerville Old Face", 14.25F);
            txtNombre.Location = new Point(199, 160);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 29);
            txtNombre.TabIndex = 26;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Baskerville Old Face", 14.25F);
            txtTelefono.Location = new Point(199, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 29);
            txtTelefono.TabIndex = 27;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Baskerville Old Face", 14.25F);
            txtDireccion.Location = new Point(199, 241);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(258, 29);
            txtDireccion.TabIndex = 28;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(199, 321);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 30);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // RegistrarProvedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 577);
            Controls.Add(btnGuardar);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtProductor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cedula);
            Controls.Add(menuStrip1);
            Name = "RegistrarProvedores";
            Text = "RegistrarProvedores";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ubicacionToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem carritoToolStripMenuItem;
        private ToolStripMenuItem registroProvedorToolStripMenuItem;
        private ToolStripMenuItem actualizarDatosDeCuentaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private HelpProvider helpProvider1;
        private Label Cedula;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProductor;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnGuardar;
    }
}