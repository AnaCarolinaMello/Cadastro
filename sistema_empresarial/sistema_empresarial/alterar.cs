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
    public partial class alterar : Form
    {
        public alterar()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        DateTime data;

        public void limpar()
        {
            txtcodigoreu.Clear();
            cbx_dep.SelectedIndex = -1;
            txtcodigodep.Clear();
            dtp_data.Text = DateTime.Now.ToString();
            txtmotivo.Clear();
            txtcodigoreu.Focus();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            data = DateTime.Parse(dtp_data.Text);
            sql = string.Format("update REUNIOES set DATA = '{0}',DESCRICAO = '{1}',DEPARTAMENTO_ID = '{2}' where ID = '{3}'",data.ToString("yyyy-MM-dd"), txtmotivo.Text, txtcodigodep.Text,txtcodigoreu.Text);
            bd.Alterar(sql);
            MessageBox.Show("Reunião alterada com sucesso", "Alterar reunião.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar();
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
