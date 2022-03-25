
namespace sistema_empresarial
{
    partial class marcar
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.txtmotivo = new System.Windows.Forms.RichTextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.cbx_dep = new System.Windows.Forms.ComboBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(41, 169);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(316, 22);
            this.dtp_data.TabIndex = 8;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(37, 148);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(114, 17);
            this.lbl_data.TabIndex = 6;
            this.lbl_data.Text = "Data da reunião:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(36, 24);
            this.lbl_departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(102, 17);
            this.lbl_departamento.TabIndex = 5;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(38, 215);
            this.lbl_motivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(125, 17);
            this.lbl_motivo.TabIndex = 9;
            this.lbl_motivo.Text = "Motivo da reunião:";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(41, 235);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(316, 204);
            this.txtmotivo.TabIndex = 11;
            this.txtmotivo.Text = "";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(217, 463);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(128, 53);
            this.btn_limpar.TabIndex = 13;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(49, 463);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(128, 53);
            this.btn_confirmar.TabIndex = 12;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // cbx_dep
            // 
            this.cbx_dep.FormattingEnabled = true;
            this.cbx_dep.Items.AddRange(new object[] {
            "Administração",
            "Contabilidade",
            "Recursos humanos",
            "TI",
            "Manutenção"});
            this.cbx_dep.Location = new System.Drawing.Point(40, 45);
            this.cbx_dep.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_dep.Name = "cbx_dep";
            this.cbx_dep.Size = new System.Drawing.Size(237, 24);
            this.cbx_dep.TabIndex = 7;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(36, 85);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(168, 17);
            this.lbl_codigo.TabIndex = 14;
            this.lbl_codigo.Text = "Código do departamento:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(38, 105);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(239, 22);
            this.txtcodigo.TabIndex = 15;
            // 
            // marcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 543);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.cbx_dep);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_departamento);
            this.Name = "marcar";
            this.Text = "marcar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.RichTextBox txtmotivo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.ComboBox cbx_dep;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}