using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class Exibir : Form
    {
        public Exibir()
        {
            InitializeComponent();
        }

        private void operacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financeDataSet);

        }

        private void Exibir_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'financeDataSet.Operacao'. Você pode movê-la ou removê-la conforme necessário.
            this.operacaoTableAdapter.Fill(this.financeDataSet.Operacao);

        }
    }
}
