using System.Drawing.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string textoUsuario = textBox1.Text;
            string textoContraseña = Contrasena_Campo.Text;

            if (textoContraseña.Equals("hola") && textoUsuario.Equals("hola"))
            {
                
                Form2 formulario2= new Form2();

                formulario2.label1.Text=textBox1.Text;

                formulario2.Show();
            }
            else {
                MessageBox.Show("Contraseña o usuario incorrectos");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Contrasena(object sender, EventArgs e)
        {

        }

        private void Usuario(object sender, EventArgs e)
        {
            
        }
    }
}
