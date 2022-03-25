
namespace sistema_empresarial
{
    partial class alterar
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
            this.txtcodigodep = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.txtmotivo = new System.Windows.Forms.RichTextBox();
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.cbx_dep = new System.Windows.Forms.ComboBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.txtcodigoreu = new System.Windows.Forms.TextBox();
            this.lblcodigoreu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcodigodep
            // 
            this.txtcodigodep.Location = new System.Drawing.Point(40, 158);
            this.txtcodigodep.Name = "txtcodigodep";
            this.txtcodigodep.Size = new System.Drawing.Size(239, 22);
            this.txtcodigodep.TabIndex = 25;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(38, 138);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(168, 17);
            this.lbl_codigo.TabIndex = 24;
            this.lbl_codigo.Text = "Código do departamento:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(217, 503);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(128, 53);
            this.btn_limpar.TabIndex = 23;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(49, 503);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(128, 53);
            this.btn_confirmar.TabIndex = 22;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(41, 282);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(316, 204);
            this.txtmotivo.TabIndex = 21;
            this.txtmotivo.Text = "";
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Location = new System.Drawing.Point(38, 262);
            this.lbl_motivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(125, 17);
            this.lbl_motivo.TabIndex = 20;
            this.lbl_motivo.Text = "Motivo da reunião:";
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(43, 218);
            this.dtp_data.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(316, 22);
            this.dtp_data.TabIndex = 19;
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
            this.cbx_dep.Location = new System.Drawing.Point(42, 98);
            this.cbx_dep.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_dep.Name = "cbx_dep";
            this.cbx_dep.Size = new System.Drawing.Size(237, 24);
            this.cbx_dep.TabIndex = 18;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(39, 197);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(114, 17);
            this.lbl_data.TabIndex = 17;
            this.lbl_data.Text = "Data da reunião:";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(38, 77);
            this.lbl_departamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(102, 17);
            this.lbl_departamento.TabIndex = 16;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // txtcodigoreu
            // 
            this.txtcodigoreu.Location = new System.Drawing.Point(40, 43);
            this.txtcodigoreu.Name = "txtcodigoreu";
            this.txtcodigoreu.Size = new System.Drawing.Size(239, 22);
            this.txtcodigoreu.TabIndex = 27;
            // 
            // lblcodigoreu
            // 
            this.lblcodigoreu.AutoSize = true;
            this.lblcodigoreu.Location = new System.Drawing.Point(38, 23);
            this.lblcodigoreu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigoreu.Name = "lblcodigoreu";
            this.lblcodigoreu.Size = new System.Drawing.Size(128, 17);
            this.lblcodigoreu.TabIndex = 26;
            this.lblcodigoreu.Text = "Código da reunião:";
            // 
            // alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 581);
            this.Controls.Add(this.txtcodigoreu);
            this.Controls.Add(this.lblcodigoreu);
            this.Controls.Add(this.txtcodigodep);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.cbx_dep);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_departamento);
            this.Name = "alterar";
            this.Text = "alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigodep;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.RichTextBox txtmotivo;
        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.ComboBox cbx_dep;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.TextBox txtcodigoreu;
        private System.Windows.Forms.Label lblcodigoreu;
    }
}