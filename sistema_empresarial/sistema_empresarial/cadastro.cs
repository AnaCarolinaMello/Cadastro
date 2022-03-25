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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;

        public void limpar()
        {
            txtnome.Clear();
            txtemail.Clear();
            txtsenha.Clear();
            txtnome.Focus();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            bool validacao = email.Contains("@") && email.Contains(".com");
            if(validacao == true)
            {
                int dep = 0;
                string dep1 = cbxdep.Text;
                if (dep1 == "Administração")
                {
                    dep = 1;

                }
                else if (dep1 == "Contabilidade")
                {
                    dep = 2;

                }
                else if (dep1 == "Recursos humanos")
                {
                    dep = 3;

                }
                else if (dep1 == "TI")
                {
                    dep = 4;

                }
                else
                {
                    dep = 5;
                }

                sql = string.Format("insert into FUNCIONARIOS values(null,'{0}','{1}','{2}','{3}')",
                    txtnome.Text, txtemail.Text, txtsenha.Text, dep);
                bd.Alterar(sql);
                MessageBox.Show("Funcionário cadastrado com sucesso", "Cadastro de funcionário.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                this.Visible = false;
                Form1 Form1 = new Form1();
                Form1.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("E-mail inválido", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Clear();
                txtemail.Focus();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menu menu = new menu();
            menu.ShowDialog();
            this.Visible = true;
        }
    }
}
