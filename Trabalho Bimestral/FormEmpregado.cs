﻿using System;
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
        int filhos=0;
        public int tipo = -1;//tipo do empregado 0 = Mensal 1=Horista 2=Comissionado
        public FormPrincipal f = new FormPrincipal();

        public FormEmpregado(FormPrincipal f, int tipo, EmpregadoMensal empm)
        {            
            f.empm = empm;
            this.f = f;
            this.tipo = tipo;
            InitializeComponent();

        }
        public FormEmpregado(FormPrincipal f, int tipo, EmpregadoHorista emph)
        {
            f.emph = emph;
            this.f = f;
            this.tipo = tipo;
            InitializeComponent();

        }
        public FormEmpregado(FormPrincipal f, int tipo, EmpregadoComissionado empc)
        {
            f.empc = empc;
            this.f = f;
            this.tipo = tipo;
            InitializeComponent();
        }        
        private void chkinvalido_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            //código para habilitar somente uma seleção de item por vez no checkedlistbox
            for (int ix = 0; ix < chkinvalido.Items.Count; ++ix)
            {
                if (ix != e.Index) chkinvalido.SetItemChecked(ix, false);
            }
        }
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
        private void btnfilho_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(f.emph.CPF);
            bool invalido;
            if (chkinvalido.SelectedIndex == 0)
            {
                filhos++;
                invalido = true;
            }
            else
            {
                if (Convert.ToDateTime(txtnascimento.Text).AddYears(14) > DateTime.Now)
                    filhos++;
                invalido = false;
            }
            if (tipo == 0)
            {
                f.empm.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido,lstfilho);

            }
            else if (tipo == 1)
            {
                f.emph.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido, lstfilho);
            }
            else if (tipo == 2)
            {
                f.empc.InsereFilho(this, txtnome.Text, txtcpf.Text, txtrg.Text, txtnascimento.Text, invalido, lstfilho);
            }
            resetar();
        }


        private void chkinvalido_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //código para habilitar somente uma seleção de item por vez no checkedlistbox
            for (int ix = 0; ix < chkinvalido.Items.Count; ++ix)
            {
                if (ix != e.Index) chkinvalido.SetItemChecked(ix, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            
            //this.Size = new Size(900, 410);
            f.empm.faltas = Convert.ToInt64(txtfaltas.text);
            f.empm.CalculaSalarioBruto();

        }
    }
}
