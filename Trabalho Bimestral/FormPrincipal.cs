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
        //INSTANCIA OS TRES TIPOS DE EMPREGADOS PARA PASSA-LOS  PARA O FORMEMPREGADO
            public EmpregadoMensal empm = new EmpregadoMensal();
            public EmpregadoHorista emph = new EmpregadoHorista();
            public EmpregadoComissionado empc = new EmpregadoComissionado();
        //#######################
        
        public FormPrincipal()
        {

            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        //CHECKEDLISTBOX PARA ESCOLHER O TIPO DE EMPREGADO
            private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
            {         
                //código para habilitar somente uma seleção de item por vez no checkedlistbox
                 for (int ix = 0; ix < chksalario.Items.Count; ++ix)
                 {
                   if (ix != e.Index) chksalario.SetItemChecked(ix, false);
                 }
                 
            }
        //###################################################
        //METODO PARA LIMPAR CAMPOS PREENCHIDOS
            public void resetar(int posicao)
            {
                //RECEBE A POSICAO MARCADA DO CHECKEDLISTBOX PARA LIMPA-LO(0,1,2)
                chksalario.SetItemChecked(posicao, false);
                chksalario.SelectedItem = null;
                txtnome.Text = null;
                txtcpf.Text = null;
                txtrg.Text = null;
                txtnascimento.Text = null;
                txtcarteiratrabalho.Text = null;
                txtdataadmissao.Text = null;
            }
        //######################
        //METODO COM SOBRECARGA PARA VERIFICAR SE OS CAMPOS FORAM PREENCHIDOS
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
        //##################################
        //METODO PARA ADICIONAR COMPONENTES AO FORMEMPREGADO DEPENDENDO DO TIPO DE EMPREGADO
            public void AdicionarElementos(FormEmpregado f, int tipo)
            {
                if (tipo == 0)//MENSALISTA
                {
                    //FALTAS
                        f.lblfaltas.Parent = f;
                        f.lblfaltas.Location = new System.Drawing.Point(433, 42);
                        f.lblfaltas.Text = ("Número de Faltas");
                        f.lblfaltas.Size = new System.Drawing.Size(90, 13);
                        f.txtfaltas = new TextBox();
                        f.txtfaltas.Parent = f;
                        f.txtfaltas.Location = new System.Drawing.Point(436, 58);
                    //SALARIO BASE
                        f.lblsalario.Parent = f;
                        f.lblsalario.Location = new System.Drawing.Point(433, 104);
                        f.lblsalario.Text = ("Salário Base");
                        f.lblsalario.Size = new System.Drawing.Size(76, 13);
                        f.txtsalario = new TextBox();
                        f.txtsalario.Parent = f;
                        f.txtsalario.Location = new System.Drawing.Point(436, 120);
                    //HORAS EXTRA
                        f.lblhoraextra.Parent = f;
                        f.lblhoraextra.Location = new System.Drawing.Point(433, 166);
                        f.lblhoraextra.Text = ("Horas Extras");
                        f.lblhoraextra.Size = new System.Drawing.Size(70, 13);
                        f.txthoraextra = new TextBox();
                        f.txthoraextra.Parent = f;
                        f.txthoraextra.Location = new System.Drawing.Point(436, 182);
                }
                else if (tipo == 1)//HORISTA
                {
                    //VALOR DO SALARIO POR HORA
                        f.lblsalariohora.Parent = f;
                        f.lblsalariohora.Location = new System.Drawing.Point(433, 104);
                        f.lblsalariohora.Text = ("Valor da Hora Trabalhada");
                        f.lblsalariohora.Size = new System.Drawing.Size(200, 13);                   
                        f.txtsalariohora.Parent = f;
                        f.txtsalariohora.Location = new System.Drawing.Point(436, 120);
                    //HORAS TRABALHADAS
                        f.lblhorastrabalhadas.Parent = f;
                        f.lblhorastrabalhadas.Location = new System.Drawing.Point(433, 166);
                        f.lblhorastrabalhadas.Text = ("Horas Trabalhadas");
                        f.lblhorastrabalhadas.Size = new System.Drawing.Size(100, 13);                    
                        f.txthorastrabalhadas.Parent = f;
                        f.txthorastrabalhadas.Location = new System.Drawing.Point(436, 182);
                }
                else if (tipo == 2)//COMISSIONADO
                {
                    //VALOR VENDIDO
                        f.lblvalorvendido.Parent = f;
                        f.lblvalorvendido.Location = new System.Drawing.Point(433, 104);
                        f.lblvalorvendido.Text = ("Valor Vendido");
                        f.lblvalorvendido.Size = new System.Drawing.Size(100, 13);                    
                        f.txtvalorvendido.Parent = f;
                        f.txtvalorvendido.Location = new System.Drawing.Point(436, 120);
                    //TAXA DE COMICAO EM RELACAO AO VALOR VENDIDO %
                        f.lbltaxadecomissao.Parent = f;
                        f.lbltaxadecomissao.Location = new System.Drawing.Point(433, 166);
                        f.lbltaxadecomissao.Text = ("Taxa de Comissão");
                        f.lbltaxadecomissao.Size = new System.Drawing.Size(100, 13);                    
                        f.txttaxadecomissao.Parent = f;
                        f.txttaxadecomissao.Location = new System.Drawing.Point(436, 182);     
                }
            }
        //#####################################################
        //BOTAO PARA INSERIR DADOS DO EMPREGADO E PASSAR PARA O FORM EMPREGADO
            public void btniniciar_Click(object sender, EventArgs e)
            {
                //VERIFICA SE OS CAMPOS FORAM PREENCHIDOS CORRETAMENTE
                if ((Verificar(txtnome) == true) && (Verificar(txtrg) == true) && (Verificar(txtcpf) == true) && (Verificar(txtnascimento) == true) && (Verificar(txtdataadmissao) == true) && (Verificar(txtcarteiratrabalho) == true))
                {
                    if (chksalario.SelectedIndex == 0)//EMPREGADO MENSALISTA
                    {
                        empm.Nome = txtnome.Text;
                        empm.CPF = txtcpf.Text;
                        empm.RG = txtrg.Text;
                        empm.CarteiraTrabalho = txtcarteiratrabalho.Text;
                        empm.DataAdmissao = txtdataadmissao.Text;
                        FormEmpregado empregado = new FormEmpregado(this, 0, emph);
                        empregado.Text = txtnome.Text;
                        empm.dtnasc = txtnascimento.Text;

                        resetar(0);
                        AdicionarElementos(empregado, 0);
                        empregado.ShowDialog();

                    }
                    else if (chksalario.SelectedIndex == 1)//EMPREGADO HORISTA
                    {
                        emph.Nome = txtnome.Text;
                        emph.CPF = txtcpf.Text;
                        emph.RG = txtrg.Text;
                        emph.dtnasc = txtnascimento.Text;
                        emph.CarteiraTrabalho = txtcarteiratrabalho.Text;
                        emph.DataAdmissao = txtdataadmissao.Text;
                        FormEmpregado empregado = new FormEmpregado(this, 1, emph);
                        empregado.Text = txtnome.Text;
                        resetar(1);
                        AdicionarElementos(empregado, 1);
                        empregado.ShowDialog();
                    }
                    else if (chksalario.SelectedIndex == 2)//EMPREGADO COMISSIONADO
                    {
                        empc.Nome = txtnome.Text;
                        empc.CPF = txtcpf.Text;
                        empc.RG = txtrg.Text;
                        empc.dtnasc = txtnascimento.Text;
                        empc.CarteiraTrabalho = txtcarteiratrabalho.Text;
                        empc.DataAdmissao = txtdataadmissao.Text;
                        FormEmpregado empregado = new FormEmpregado(this, 2, emph);
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
        //############################################

    }
}
