namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(); // adicionar

            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new(); // remover

            form3.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new(); // listar

            form4.Show();
        }
    }
}
