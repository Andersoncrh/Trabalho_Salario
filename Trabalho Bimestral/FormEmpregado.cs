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
    public partial class FormEmpregado:Form
    {
        int invalidos=0;//soma dos filhos menores de 14 anos e filhos com invalides
        public int tipo = -1;//tipo do empregado 0 = Mensal 1=Horista 2=Comissionado
        public FormPrincipal f = new FormPrincipal();
        //######CONTROLADORES VISIVEIS DEPENDENDO DO TIPO DE EMPREGADO######
            //MENSALISTA
                public Label lblfaltas = new Label();
                public TextBox txtfaltas = new TextBox();
                public Label lblsalario = new Label();
                public TextBox txtsalario = new TextBox();
                public Label lblhoraextra = new Label();
                public TextBox txthoraextra = new TextBox();
            //HORISTA
                public Label lblsalariohora = new Label();
                public TextBox txtsalariohora = new TextBox();
                public Label lblhorastrabalhadas = new Label();
                public TextBox txthorastrabalhadas = new TextBox();
            //COMISSIONADO
                public Label lblvalorvendido = new Label();
                public TextBox txtvalorvendido = new TextBox();
                public Label lbltaxadecomissao = new Label();
                public TextBox txttaxadecomissao = new TextBox();
        //###########################################################


        //SOBRECARGA DE CONSTUCTO DEPENDENDO DO TIPO DE EMPREGADO
            public FormEmpregado(FormPrincipal f, int tipo, EmpregadoMensal empm)
            {            
                this.f.empm = empm;
                this.tipo = tipo;
                StartPosition = FormStartPosition.CenterScreen;
                InitializeComponent();

            }
            public FormEmpregado(FormPrincipal f, int tipo, EmpregadoHorista emph)
            {
                this.f.emph = emph;
                this.tipo = tipo;
                StartPosition = FormStartPosition.CenterScreen;
                InitializeComponent();

            }
            public FormEmpregado(FormPrincipal f, int tipo, EmpregadoComissionado empc)
            {
                this.f.empc = empc;
                this.tipo = tipo;
                StartPosition = FormStartPosition.CenterScreen;
                InitializeComponent();
            }        
        //###############################################
        //RESETAR CONTROLADORES DO FILHO
            public void resetar()
            {
                chkinvalido.SetItemChecked(0, false);
                chkinvalido.SetItemChecked(1, false);
                chkinvalido.SelectedItem = null;
                txtnome.Text = null;
                txtcpf.Text = null;
                txtrg.Text = null;
                txtnascimento.Text = null;
            }
        //##########################
            //BOTAO PARA INSERIR FILHO
            private void btnfilho_Click(object sender, EventArgs e)
            {
                bool invalido;//GUARDA SE FILHO EH OU NAO INVALIDO PARA PASSAR POR PARAMETRO AO METO INSEREFILHO
                //INCREMENTA A VARIAVEL INVALIDOS CASO O FILHO SEJA MENOR DE IDADE OU INVALIDO
                if ((f.Verificar(txtnome) == true) && (f.Verificar(txtrg) == true) && (f.Verificar(txtcpf) == true) && (f.Verificar(txtnascimento) == true))
                {
                    if (chkinvalido.SelectedIndex == 0)
                    {
                        //VERIFICA SE O FILHO TEM INVALIDEZ
                        invalidos++;
                        invalido = true;
                    }
                    else
                    {
                        //VERIFICA SE O FILHO TEM MENOS DE 15 ANOS
                        if (Convert.ToDateTime(txtnascimento.Text).AddYears(14) >= DateTime.Now)
                            invalidos++;
                        //##########################################
                        invalido = false;
                    }
                    //######################

                    if (tipo == 0)//INSERE FILHO PARA EMPREGADO MENSAL
                    {
                        f.empm.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido, lstfilho);

                    }
                    else if (tipo == 1)//INSERE FILHO PARA EMPREGADO HORISTA
                    {
                        f.emph.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido, lstfilho);
                    }
                    else if (tipo == 2)//INSERE FILHO PARA EMPREGADO COMISSIONADO
                    {
                        f.empc.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido, lstfilho);
                    }
                    resetar();
                }
                else
                    MessageBox.Show("Certifique-se que todos os campos relativos ao filho foram Preenchidos corretamente, caso nao exista informacao para algum campo complete-o com 0");
            }
        //###########################################
        //CHECKED LIST BOX INVALIDEZ DO FILHO
            private void chkinvalido_ItemCheck(object sender, ItemCheckEventArgs e)
            {
                //código para habilitar somente uma seleção de item por vez no checkedlistbox
                for (int ix = 0; ix < chkinvalido.Items.Count; ++ix)
                {
                    if (ix != e.Index) chkinvalido.SetItemChecked(ix, false);
                }
            }
        //########################################
        //BOTAO PARA CHAMAR OS CALCULOS
        private void button1_Click(object sender, EventArgs e)
        {
             //VERIFICA SE OS CAMPOS FORAM PREENCHIDOS CORRETAMENTE E ENVIA OS DADOS PARA A CLASSE
            //VERIFICA O TIPO DE EMPREGADO PARA CHAMAR OS CALCULOS ESPECIFICOS
                if (tipo == 0)//SE FOR EMPREGADO MENSAL
                {
                    if ((f.Verificar(txtfaltas) == true) && (f.Verificar(txtsalario) == true) && (f.Verificar(txthoraextra) == true))
                    {
                        f.empm.faltas = Convert.ToDouble(txtfaltas.Text);
                        f.empm.HorasExtras = Convert.ToDouble(txthoraextra.Text);
                        f.empm.SalarioMensal = Convert.ToDouble(txtsalario.Text);
                        f.empm.CalculaSalarioBruto();
                        f.empm.invalidos = this.invalidos;
                        MessageBox.Show("Salário Bruto: " + f.empm.CalculaSalarioBruto().ToString("N2") +
                            "\nSalário Família: " + f.empm.CalculaSalarioFamilia().ToString("N2") +
                            "\nDesconto do INSS: " + f.empm.CalculaInss().ToString("N2")+
                            "\nSalário Líquido: " + f.empm.CalculaSalarioLiquido().ToString("N2"));
                    }
                    else
                        MessageBox.Show("Preencha os campos: Faltas, Salário e Hora Extra, adequadamente e caso não possua nenhum valor para algum campo coloque 0");
                }
                else if (tipo == 1)//SE FOR EMPREGADO HORISTA
                {
                    if ((f.Verificar(txtsalariohora) == true)&& (f.Verificar(txthorastrabalhadas) == true))
                    {
                        f.emph.SalarioHora = Convert.ToDouble(txtsalariohora.Text);
                        f.emph.HorasTrabalhadas = Convert.ToDouble(txthorastrabalhadas.Text);
                        f.emph.invalidos = invalidos;
                        f.emph.invalidos = this.invalidos;
                        MessageBox.Show("Salario Bruto: " + f.emph.CalculaSalarioBruto().ToString("N2") +
                            "\nSalário Família: " + f.emph.CalculaSalarioFamilia().ToString("N2") +
                            "\nDesconto do INSS: " + f.emph.CalculaInss().ToString("N2") +
                            "\nSalário Líquido: " + f.emph.CalculaSalarioLiquido().ToString("N2"));
                    }
                    else
                        MessageBox.Show("Preencha os campos Valor da Hora Trabalhada e Horas Trabalhadas corretamente");
                }
                else if (tipo == 2)//SE FOR EMPREGADO COMISSIONADO
                {
                    if ((f.Verificar(txtvalorvendido) == true) && (f.Verificar(txttaxadecomissao) == true))
                    {
                        f.empc.ValorVendido = Convert.ToDouble(txtvalorvendido.Text);
                        f.empc.TaxadeComissao = Convert.ToDouble(txttaxadecomissao.Text);
                        f.empc.invalidos = invalidos;
                        f.empc.invalidos = this.invalidos;
                        MessageBox.Show("Salario Bruto: " + f.empc.CalculaSalarioBruto().ToString("N2") +
                            "\nSalário Família: " + f.empc.CalculaSalarioFamilia().ToString("N2") +
                            "\nDesconto do INSS: " + f.empc.CalculaInss().ToString("N2") +
                            "\nSalário Líquido: " + f.empc.CalculaSalarioLiquido().ToString("N2"));
                    }
                    else
                        MessageBox.Show("Preencha os campos Valor da Hora Trabalhada e Horas Trabalhadas corretamente");
                }
            //############################################

        }
    }
}
