using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosAleatorio
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonModeDadoNormal_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new(GameMode.DadoNormal);
            gameForm.Show();
            this.Hide();
        }

        private void buttonModeDadoViciado_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new(GameMode.DadoViciado);
            gameForm.Show();
            this.Hide();
        }
    }
}
