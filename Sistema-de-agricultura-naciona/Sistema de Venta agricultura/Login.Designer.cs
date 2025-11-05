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
            label4 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(112, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 108);
            label1.TabIndex = 0;
            label1.Text = "Sistema \r\nAgricola Naciona\r\n";
            label1.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.RoyalBlue;
            btnIngresar.Font = new Font("Baskerville Old Face", 16F);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(822, 525);
            btnIngresar.Margin = new Padding(4, 5, 4, 5);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(224, 49);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 16F);
            label2.Location = new Point(822, 288);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 36);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 16F);
            label3.Location = new Point(822, 408);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 36);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Baskerville Old Face", 16F);
            btnRegistrar.Location = new Point(1063, 525);
            btnRegistrar.Margin = new Padding(4, 5, 4, 5);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 49);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtuser
            // 
            txtuser.BackColor = SystemColors.Window;
            txtuser.Cursor = Cursors.IBeam;
            txtuser.Font = new Font("Baskerville Old Face", 16F);
            txtuser.Location = new Point(822, 329);
            txtuser.Margin = new Padding(4, 5, 4, 5);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(379, 44);
            txtuser.TabIndex = 5;
            txtuser.TextChanged += textBox1_TextChanged_1;
            // 
            // txtpassword
            // 
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Baskerville Old Face", 16F);
            txtpassword.Location = new Point(822, 460);
            txtpassword.Margin = new Padding(4, 5, 4, 5);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(379, 44);
            txtpassword.TabIndex = 6;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Baskerville Old Face", 16F);
            btnLimpiar.Location = new Point(758, 850);
            btnLimpiar.Margin = new Padding(4, 5, 4, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 63);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(802, 156);
            label4.Name = "label4";
            label4.Size = new Size(415, 64);
            label4.TabIndex = 8;
            label4.Text = "Inicio de Sesion ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 958);
            panel1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1428, 962);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(btnRegistrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Sistema de Agricultura";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label4;
        private Panel panel1;
    }
}
