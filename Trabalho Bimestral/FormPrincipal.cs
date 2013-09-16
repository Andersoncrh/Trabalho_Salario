using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Trabalho_Bimestral
{
    public partial class FormPrincipal : Form
    {
        public EmpregadoMensal empm = new EmpregadoMensal();
        public EmpregadoHorista emph = new EmpregadoHorista();
        public EmpregadoComissionado empc = new EmpregadoComissionado();
        
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {         
            //código para habilitar somente uma seleção de item por vez no checkedlistbox
             for (int ix = 0; ix < chksalario.Items.Count; ++ix)
             {
               if (ix != e.Index) chksalario.SetItemChecked(ix, false);
             }
             
        }
        public void resetar(int posicao)
        {
            chksalario.SetItemChecked(posicao, false);
            chksalario.SelectedItem = null;
            txtnome.Text = null;
            txtcpf.Text = null;
            txtrg.Text = null;
            txtnascimento.Text = null;
        }
        public bool Verificar(TextBox a)
        {
            if (a.Text == "")
                return false;
            else
                return true;
        }
        public bool Verificar(MaskedTextBox a)
        {
            if (a.MaskCompleted)
                return true;
            else
                return false;
        }
        public void AdicionarElementos(FormEmpregado f, int tipo)
        {
            if (tipo == 0)
            {
                Label lblsalario = new Label();
                lblsalario.Parent = f;
                lblsalario.Location = new System.Drawing.Point(314, 34);
                lblsalario.Text = ("Salário Mensal");
                lblsalario.Size = new System.Drawing.Size(76, 13);
                TextBox txtsalario = new TextBox();
                txtsalario.Parent = f;
                txtsalario.Location = new System.Drawing.Point(317, 50);
                Label lblhoraextra = new Label();
                lblhoraextra.Parent = f;
                lblhoraextra.Location = new System.Drawing.Point(314, 81);
                lblhoraextra.Text = ("Horas Extras");
                lblhoraextra.Size = new System.Drawing.Size(70, 13);
                TextBox txthoraextra = new TextBox();
                txthoraextra.Parent = f;
                txthoraextra.Location = new System.Drawing.Point(317, 97);
            }
            else if (tipo == 1)
            {
                Label lblsalariohora = new Label();
                lblsalariohora.Parent = f;
                lblsalariohora.Location = new System.Drawing.Point(314, 34);
                lblsalariohora.Text = ("Valor da Hora Trabalhada");
                lblsalariohora.Size = new System.Drawing.Size(200, 13);
                TextBox txtsalariohora = new TextBox();
                txtsalariohora.Parent = f;
                txtsalariohora.Location = new System.Drawing.Point(317, 50);
                Label lblhorastrabalhadas = new Label();
                lblhorastrabalhadas.Parent = f;
                lblhorastrabalhadas.Location = new System.Drawing.Point(314, 81);
                lblhorastrabalhadas.Text = ("Horas Trabalhadas");
                lblhorastrabalhadas.Size = new System.Drawing.Size(100, 13);
                TextBox txthorastrabalhadas = new TextBox();
                txthorastrabalhadas.Parent = f;
                txthorastrabalhadas.Location = new System.Drawing.Point(317, 97);
            }
            else
            {
                Label lblvalorvendido = new Label();
                lblvalorvendido.Parent = f;
                lblvalorvendido.Location = new System.Drawing.Point(314, 34);
                lblvalorvendido.Text = ("Valor Vendido");
                lblvalorvendido.Size = new System.Drawing.Size(100, 13);
                TextBox txtvalorvendido = new TextBox();
                txtvalorvendido.Parent = f;
                txtvalorvendido.Location = new System.Drawing.Point(317, 50);
                Label lbltaxadecomissao = new Label();
                lbltaxadecomissao.Parent = f;
                lbltaxadecomissao.Location = new System.Drawing.Point(314, 81);
                lbltaxadecomissao.Text = ("Taxa de Comissão");
                lbltaxadecomissao.Size = new System.Drawing.Size(100, 13);
                TextBox txttaxadecomissao = new TextBox();
                txttaxadecomissao.Parent = f;
                txttaxadecomissao.Location = new System.Drawing.Point(317, 97);
 
            }

        }

        
        public void btniniciar_Click(object sender, EventArgs e)
        {

            if ((Verificar(txtnome) == true) && (Verificar(txtrg) == true) && (Verificar(txtcpf) == true) && (Verificar(txtnascimento) == true))
            {
                if (chksalario.SelectedIndex == 0)
                {
                    empm.Nome = txtnome.Text;
                    empm.CPF = txtcpf.Text;
                    empm.RG = txtrg.Text;
                    FormEmpregado empregado = new FormEmpregado(this, 1, emph);
                    empregado.Text = txtnome.Text;
                    empm.dtnasc = txtnascimento.Text;
                    resetar(0);
                    AdicionarElementos(empregado, 0);
                    empregado.ShowDialog();

                }
                else if (chksalario.SelectedIndex == 1)
                {
                    emph.Nome = txtnome.Text;
                    emph.CPF = txtcpf.Text;
                    emph.RG = txtrg.Text;
                    emph.dtnasc = txtnascimento.Text;
                    FormEmpregado empregado = new FormEmpregado(this, 1, emph);
                    empregado.Text = txtnome.Text;
                    resetar(1);
                    AdicionarElementos(empregado, 1);
                    empregado.ShowDialog();
                }
                else if (chksalario.SelectedIndex == 2)
                {
                    empc.Nome = txtnome.Text;
                    empc.CPF = txtcpf.Text;
                    empc.RG = txtrg.Text;
                    empc.dtnasc = txtnascimento.Text;
                    FormEmpregado empregado = new FormEmpregado(this, 1, emph);
                    empregado.Text = txtnome.Text;
                    resetar(2);
                    AdicionarElementos(empregado, 2);
                    empregado.ShowDialog();
                }
                else
                    MessageBox.Show("Escolha o Tipo de Empregado");
            }
            else
                MessageBox.Show("Certifique-se que todos os campos foram Preenchidos");
        }        

    }
}
