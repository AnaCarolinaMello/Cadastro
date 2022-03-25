
namespace sistema_empresarial
{
    partial class menu
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
            this.lblsistema = new System.Windows.Forms.Label();
            this.btncadastro = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsistema
            // 
            this.lblsistema.AutoSize = true;
            this.lblsistema.Location = new System.Drawing.Point(77, 60);
            this.lblsistema.Name = "lblsistema";
            this.lblsistema.Size = new System.Drawing.Size(136, 17);
            this.lblsistema.TabIndex = 5;
            this.lblsistema.Text = "Sistema empresarial";
            // 
            // btncadastro
            // 
            this.btncadastro.Location = new System.Drawing.Point(63, 113);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(164, 72);
            this.btncadastro.TabIndex = 4;
            this.btncadastro.Text = "Cadastro";
            this.btncadastro.UseVisualStyleBackColor = true;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(63, 249);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(164, 67);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Entrar";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 396);
            this.Controls.Add(this.lblsistema);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.btnlogin);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsistema;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btnlogin;
    }
}