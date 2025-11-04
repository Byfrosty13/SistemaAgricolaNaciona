namespace Sistema_de_Venta_agricultura
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtuser.Clear();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
           


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro registroUsuario = new Registro();
            registroUsuario.Show();
            this.Hide();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            PagInicial paginicial = new PagInicial();
            paginicial.Show();
            this.Hide();
        }
    }
}
