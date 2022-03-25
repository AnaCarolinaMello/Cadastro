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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login login = new login();
            login.ShowDialog();
            this.Visible = true;
        }
    }
}
