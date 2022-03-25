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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        Log log = new Log();

        public void limpar()
        {
            txtemail.Clear();
            txtsenha.Clear();
            txtemail.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (log.Validarlog(txtemail.Text, txtsenha.Text))
            {
                this.Visible = false;
                Form1 Form1 = new Form1();
                Form1.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("E-mail ou senha inválidos", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
