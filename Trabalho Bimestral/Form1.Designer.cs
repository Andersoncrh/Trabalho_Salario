namespace Trabalho_Bimestral
{
    partial class FormPrincipal
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chksalario = new System.Windows.Forms.CheckedListBox();
            this.txtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtdataadmissao = new System.Windows.Forms.MaskedTextBox();
            this.lbldataadmissao = new System.Windows.Forms.Label();
            this.txtcarteiratrabalho = new System.Windows.Forms.TextBox();
            this.lblcarteiratrabalho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(105, 43);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(82, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "Nome Completo";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(223, 43);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(23, 13);
            this.lblrg.TabIndex = 2;
            this.lblrg.Text = "RG";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(341, 43);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 3;
            this.lblcpf.Text = "CPF";
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(460, 43);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(104, 13);
            this.lblnascimento.TabIndex = 4;
            this.lblnascimento.Text = "Data de Nascimento";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(109, 59);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 1;
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(252, 219);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(156, 59);
            this.btniniciar.TabIndex = 8;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Empregado";
            // 
            // chksalario
            // 
            this.chksalario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chksalario.CheckOnClick = true;
            this.chksalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chksalario.Items.AddRange(new object[] {
            "Mensalista",
            "Horista",
            "Comissionado"});
            this.chksalario.Location = new System.Drawing.Point(149, 164);
            this.chksalario.MultiColumn = true;
            this.chksalario.Name = "chksalario";
            this.chksalario.Size = new System.Drawing.Size(374, 19);
            this.chksalario.TabIndex = 7;
            this.chksalario.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(463, 59);
            this.txtnascimento.Mask = "00/00/0000";
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(100, 20);
            this.txtnascimento.TabIndex = 4;
            this.txtnascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(344, 59);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 3;
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(226, 59);
            this.txtrg.Mask = "00,000,000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 20);
            this.txtrg.TabIndex = 2;
            // 
            // txtdataadmissao
            // 
            this.txtdataadmissao.Location = new System.Drawing.Point(344, 104);
            this.txtdataadmissao.Mask = "00/00/0000";
            this.txtdataadmissao.Name = "txtdataadmissao";
            this.txtdataadmissao.Size = new System.Drawing.Size(100, 20);
            this.txtdataadmissao.TabIndex = 6;
            this.txtdataadmissao.ValidatingType = typeof(System.DateTime);
            // 
            // lbldataadmissao
            // 
            this.lbldataadmissao.AutoSize = true;
            this.lbldataadmissao.Location = new System.Drawing.Point(341, 88);
            this.lbldataadmissao.Name = "lbldataadmissao";
            this.lbldataadmissao.Size = new System.Drawing.Size(93, 13);
            this.lbldataadmissao.TabIndex = 11;
            this.lbldataadmissao.Text = "Data de Admissão";
            // 
            // txtcarteiratrabalho
            // 
            this.txtcarteiratrabalho.Location = new System.Drawing.Point(226, 104);
            this.txtcarteiratrabalho.Name = "txtcarteiratrabalho";
            this.txtcarteiratrabalho.Size = new System.Drawing.Size(100, 20);
            this.txtcarteiratrabalho.TabIndex = 5;
            // 
            // lblcarteiratrabalho
            // 
            this.lblcarteiratrabalho.AutoSize = true;
            this.lblcarteiratrabalho.Location = new System.Drawing.Point(222, 88);
            this.lblcarteiratrabalho.Name = "lblcarteiratrabalho";
            this.lblcarteiratrabalho.Size = new System.Drawing.Size(103, 13);
            this.lblcarteiratrabalho.TabIndex = 13;
            this.lblcarteiratrabalho.Text = "Carteira de Trabalho";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 323);
            this.Controls.Add(this.txtcarteiratrabalho);
            this.Controls.Add(this.lblcarteiratrabalho);
            this.Controls.Add(this.txtdataadmissao);
            this.Controls.Add(this.lbldataadmissao);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.chksalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.lblnome);
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox chksalario;
        private System.Windows.Forms.MaskedTextBox txtnascimento;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtdataadmissao;
        private System.Windows.Forms.Label lbldataadmissao;
        private System.Windows.Forms.TextBox txtcarteiratrabalho;
        private System.Windows.Forms.Label lblcarteiratrabalho;



    }
}

