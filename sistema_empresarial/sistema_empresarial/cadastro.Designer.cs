
namespace sistema_empresarial
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cbxdep = new System.Windows.Forms.ComboBox();
            this.lbldep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(348, 188);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(179, 54);
            this.btnvoltar.TabIndex = 36;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(78, 188);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(179, 54);
            this.btnconfirmar.TabIndex = 35;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(315, 105);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(53, 17);
            this.lblsenha.TabIndex = 30;
            this.lblsenha.Text = "Senha:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(41, 105);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 17);
            this.lblemail.TabIndex = 29;
            this.lblemail.Text = "E-mail:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(41, 29);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 17);
            this.lblnome.TabIndex = 25;
            this.lblnome.Text = "Nome:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(318, 136);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(239, 22);
            this.txtsenha.TabIndex = 23;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(44, 136);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(239, 22);
            this.txtemail.TabIndex = 22;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(44, 56);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(239, 22);
            this.txtnome.TabIndex = 19;
            // 
            // cbxdep
            // 
            this.cbxdep.FormattingEnabled = true;
            this.cbxdep.Items.AddRange(new object[] {
            "Administração",
            "Contabilidade",
            "Recursos humanos",
            "TI",
            "Manutenção"});
            this.cbxdep.Location = new System.Drawing.Point(318, 56);
            this.cbxdep.Name = "cbxdep";
            this.cbxdep.Size = new System.Drawing.Size(239, 24);
            this.cbxdep.TabIndex = 20;
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Location = new System.Drawing.Point(315, 25);
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(102, 17);
            this.lbldep.TabIndex = 31;
            this.lbldep.Text = "Departamento:";
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 277);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.cbxdep);
            this.Controls.Add(this.txtnome);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cbxdep;
        private System.Windows.Forms.Label lbldep;
    }
}