namespace Sistema_de_Venta_agricultura
{
    partial class Registro
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            txtCorreo = new TextBox();
            txtContra = new TextBox();
            btnRegistrar = new Button();
            btnregresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(459, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 48);
            label1.TabIndex = 0;
            label1.Text = "Pag De Registro del Agricultor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 308);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 397);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 3;
            label4.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 492);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 588);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 5;
            label6.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(459, 295);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(459, 383);
            txtCedula.Margin = new Padding(4, 5, 4, 5);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(141, 31);
            txtCedula.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(459, 487);
            txtCorreo.Margin = new Padding(4, 5, 4, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(141, 31);
            txtCorreo.TabIndex = 9;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(446, 583);
            txtContra.Margin = new Padding(4, 5, 4, 5);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(141, 31);
            txtContra.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(333, 702);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(107, 38);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnregresar
            // 
            btnregresar.Location = new Point(611, 702);
            btnregresar.Margin = new Padding(4, 5, 4, 5);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(107, 38);
            btnregresar.TabIndex = 12;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 1052);
            Controls.Add(btnregresar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtContra);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtCorreo;
        private TextBox txtContra;
        private Button btnRegistrar;
        private Button btnregresar;
    }
}