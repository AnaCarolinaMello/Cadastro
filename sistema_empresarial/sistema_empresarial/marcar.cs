using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_empresarial
{
    public partial class marcar : Form
    {
        public marcar()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        DateTime data;

        public void limpar()
        {
            cbx_dep.SelectedIndex = -1;
            txtcodigo.Clear();
            dtp_data.Text = DateTime.Now.ToString();
            txtmotivo.Clear();
            cbx_dep.Focus();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtp_data.Text);
            sql = string.Format("insert into REUNIOES values(null,'{0}','{1}','{2}')",
                data.ToString("yyyy-MM-dd"),txtmotivo.Text,txtcodigo.Text);
            bd.Alterar(sql);
            MessageBox.Show("Reunião marcada com sucesso", "Marcar reunião.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
