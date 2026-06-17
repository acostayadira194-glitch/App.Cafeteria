namespace App.Cafeteria
{
    public partial class Form1 : Form
    {
        private List<Bebida> bebidas = new List<Bebida>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbCalientes_CheckedChanged(object sender, EventArgs e)
        {
            lblVariable.Text= "temperatura";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbldescripcion.Text =
        bebidas[listBox1.SelectedIndex].Preparar();

        }

        private void rdbFria_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFria.Checked)
            {
                lblVariable.Text = "Cantidad hielo";
            }
        }

        private void rdbEnergetica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEnergetica.Checked)
            {
                lblVariable.Text = "Nivel Cafeina";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtMensaje.Text;

            if (!float.TryParse(textBox2.Text, out float precio))
            {
                MessageBox.Show("Precio: [" + textBox2.Text + "]");
                return;
            }

            string tamano = textBox3.Text;
            if (!int.TryParse(txtExtra.Text, out int extra))
            {
                MessageBox.Show("Valor extra inválido");
                return;
            }

            if (rdbCalientes.Checked)
            {
                bebidas.Add(new BebidaCaliente(nombre, tamano, precio, extra));
            }
            else if (rdbFria.Checked)
            {
                bebidas.Add(new BebidaFria(nombre, tamano, precio, extra));
            }
            else if (rdbEnergetica.Checked)
            {
                bebidas.Add(new BebidaEnergetica(nombre, tamano, precio, extra));
            }

            if (!rdbCalientes.Checked && !rdbFria.Checked && !rdbEnergetica.Checked)
            {
                MessageBox.Show("Seleccione un tipo de bebida");
                return;
            }
            if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                listBox1.Items.Add(caliente.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                listBox1.Items.Add(fria.Mensaje());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaEnergetica energetica)
            {
                listBox1.Items.Add(energetica.Mensaje());
            }

            lblconta.Text = bebidas.Count + " bebidas registradas";
            txtMensaje.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtExtra.Clear();

            rdbCalientes.Checked = false;
            rdbFria.Checked = false;
            rdbEnergetica.Checked = false;

            txtMensaje.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
