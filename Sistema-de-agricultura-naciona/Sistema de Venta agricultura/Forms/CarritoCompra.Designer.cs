namespace Sistema_de_Venta_agricultura.Forms
{
    partial class CarritoCompra
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
            dgvCarrito = new DataGridView();
            lblTotal = new Label();
            btnConfirmarCompra = new Button();
            btnEliminarItem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(213, 81);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(511, 334);
            dgvCarrito.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = SystemColors.ActiveCaption;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(589, 444);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 47);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "(               \r\n\r\n)";
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Location = new Point(690, 453);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(75, 23);
            btnConfirmarCompra.TabIndex = 2;
            btnConfirmarCompra.Text = "Comprar";
            btnConfirmarCompra.UseVisualStyleBackColor = true;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click;
            // 
            // btnEliminarItem
            // 
            btnEliminarItem.Location = new Point(271, 468);
            btnEliminarItem.Name = "btnEliminarItem";
            btnEliminarItem.Size = new Size(75, 23);
            btnEliminarItem.TabIndex = 3;
            btnEliminarItem.Text = "Cancelar";
            btnEliminarItem.UseVisualStyleBackColor = true;
            // 
            // CarritoCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 577);
            Controls.Add(btnEliminarItem);
            Controls.Add(btnConfirmarCompra);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrito);
            Name = "CarritoCompra";
            Text = "CarritoCompra";
            Load += CarritoCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarrito;
        private Label lblTotal;
        private Button btnConfirmarCompra;
        private Button btnEliminarItem;
    }
}