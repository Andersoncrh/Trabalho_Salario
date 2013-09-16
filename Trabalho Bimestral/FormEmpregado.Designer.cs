namespace Trabalho_Bimestral
{
    partial class FormEmpregado
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
            this.lstfilho = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chkinvalido = new System.Windows.Forms.CheckedListBox();
            this.lblinvalido = new System.Windows.Forms.Label();
            this.btnfilho = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblrg = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtnascimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lstfilho
            // 
            this.lstfilho.FormattingEnabled = true;
            this.lstfilho.Location = new System.Drawing.Point(21, 259);
            this.lstfilho.Name = "lstfilho";
            this.lstfilho.Size = new System.Drawing.Size(120, 95);
            this.lstfilho.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "FILHOS INSERIDOS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 96);
            this.button1.TabIndex = 39;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chkinvalido
            // 
            this.chkinvalido.CheckOnClick = true;
            this.chkinvalido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkinvalido.FormattingEnabled = true;
            this.chkinvalido.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.chkinvalido.Location = new System.Drawing.Point(19, 147);
            this.chkinvalido.MultiColumn = true;
            this.chkinvalido.Name = "chkinvalido";
            this.chkinvalido.Size = new System.Drawing.Size(250, 19);
            this.chkinvalido.TabIndex = 38;
            this.chkinvalido.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkinvalido_ItemCheck);
            // 
            // lblinvalido
            // 
            this.lblinvalido.AutoSize = true;
            this.lblinvalido.Location = new System.Drawing.Point(15, 131);
            this.lblinvalido.Name = "lblinvalido";
            this.lblinvalido.Size = new System.Drawing.Size(103, 13);
            this.lblinvalido.TabIndex = 37;
            this.lblinvalido.Text = "Filho com Invalidez?";
            // 
            // btnfilho
            // 
            this.btnfilho.Location = new System.Drawing.Point(84, 182);
            this.btnfilho.Name = "btnfilho";
            this.btnfilho.Size = new System.Drawing.Size(102, 39);
            this.btnfilho.TabIndex = 36;
            this.btnfilho.Text = "Inserir Filho";
            this.btnfilho.UseVisualStyleBackColor = true;
            this.btnfilho.Click += new System.EventHandler(this.btnfilho_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(19, 50);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 32;
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(163, 81);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(104, 13);
            this.lblnascimento.TabIndex = 31;
            this.lblnascimento.Text = "Data de Nascimento";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(14, 81);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(27, 13);
            this.lblcpf.TabIndex = 30;
            this.lblcpf.Text = "CPF";
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(163, 34);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(23, 13);
            this.lblrg.TabIndex = 29;
            this.lblrg.Text = "RG";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(15, 34);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(75, 13);
            this.lblnome.TabIndex = 28;
            this.lblnome.Text = "Nome do Filho";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(166, 50);
            this.txtrg.Mask = "00,000,000-0";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(100, 20);
            this.txtrg.TabIndex = 42;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(21, 97);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 43;
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(166, 97);
            this.txtnascimento.Mask = "00/00/0000";
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(100, 20);
            this.txtnascimento.TabIndex = 44;
            this.txtnascimento.ValidatingType = typeof(System.DateTime);
            // 
            // FormEmpregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 372);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.lstfilho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkinvalido);
            this.Controls.Add(this.lblinvalido);
            this.Controls.Add(this.btnfilho);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnascimento);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.lblnome);
            this.Name = "FormEmpregado";
            this.Text = "FormEmpregado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstfilho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox chkinvalido;
        private System.Windows.Forms.Label lblinvalido;
        private System.Windows.Forms.Button btnfilho;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.MaskedTextBox txtnascimento;
    }
}