namespace Sistema_de_Venta_agricultura
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnIngresar = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            txtuser = new TextBox();
            txtpassword = new TextBox();
            btnLimpiar = new Button();
            btntest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistema Agricola Naciona";
            label1.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(434, 354);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 38);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 215);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 279);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(577, 354);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(97, 38);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.Window;
            txtuser.Cursor = Cursors.IBeam;
            txtuser.Location = new Point(505, 215);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(169, 23);
            txtuser.TabIndex = 5;
            txtuser.TextChanged += textBox1_TextChanged_1;
            // 
            // txtpassword
            // 
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Location = new Point(505, 279);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(169, 23);
            txtpassword.TabIndex = 6;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(719, 354);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 38);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btntest
            // 
            btntest.Location = new Point(815, 245);
            btntest.Name = "btntest";
            btntest.Size = new Size(91, 30);
            btntest.TabIndex = 8;
            btntest.Text = "button1";
            btntest.UseVisualStyleBackColor = true;
            btntest.Click += btntest_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 630);
            Controls.Add(btntest);
            Controls.Add(btnLimpiar);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Name = "Login";
            Text = "Sistema de Agricultura";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIngresar;
        private Label label2;
        private Label label3;
        private Button btnRegistrar;
        private TextBox txtuser;
        private TextBox txtpassword;
        private Button btnLimpiar;
        private Button btntest;
    }
}
