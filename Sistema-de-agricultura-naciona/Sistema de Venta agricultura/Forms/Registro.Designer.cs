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
            txtContrasena = new TextBox();
            btnRegistrar = new Button();
            btnregresar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 43);
            label1.Name = "label1";
            label1.Size = new Size(362, 32);
            label1.TabIndex = 0;
            label1.Text = "Pag De Registro del Agricultor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 16F);
            label2.Location = new Point(150, 152);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 16F);
            label4.Location = new Point(150, 212);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 3;
            label4.Text = "Cedula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 16F);
            label5.Location = new Point(150, 266);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Baskerville Old Face", 16F);
            label6.Location = new Point(150, 322);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 5;
            label6.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Baskerville Old Face", 16F);
            txtNombre.Location = new Point(150, 182);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(349, 32);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtCedula
            // 
            txtCedula.Font = new Font("Baskerville Old Face", 16F);
            txtCedula.Location = new Point(150, 236);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(349, 32);
            txtCedula.TabIndex = 8;
            txtCedula.TextChanged += txtCedula_TextChanged;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Baskerville Old Face", 16F);
            txtCorreo.Location = new Point(150, 293);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(349, 32);
            txtCorreo.TabIndex = 9;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Baskerville Old Face", 16F);
            txtContrasena.Location = new Point(150, 350);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(349, 32);
            txtContrasena.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Baskerville Old Face", 16F);
            btnRegistrar.Location = new Point(150, 397);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(172, 36);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnregresar
            // 
            btnregresar.Font = new Font("Baskerville Old Face", 16F);
            btnregresar.Location = new Point(56, 391);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(172, 35);
            btnregresar.TabIndex = 12;
            btnregresar.Text = "Regresar";
            btnregresar.UseVisualStyleBackColor = true;
            btnregresar.Click += btnregresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnregresar);
            panel1.Location = new Point(271, 7);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 626);
            panel1.TabIndex = 13;
            // 
            // Registro
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(659, 631);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCorreo);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registro_Load;
            panel1.ResumeLayout(false);
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
        private TextBox txtContrasena;
        private Button btnRegistrar;
        private Button btnregresar;
        private Panel panel1;
    }
}