using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using Finance.Entidades;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Comandos cd = new Comandos();
            string at = txtAtv.Text;
            decimal g = decimal.Parse(txtGn.Text);
            decimal l = decimal.Parse(txtLoss.Text);
            DateTime dt = DateTime.Parse(txtDt.Text);
            cd = new  Comandos(at, g, dt, l);
            MessageBox.Show(cd.msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exibir ex = new Exibir();
            ex.Show();

        }
    }
}
