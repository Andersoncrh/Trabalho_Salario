using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_Bimestral
{
    public class Empregado:Pessoa
    {
        //ATRIBUTOS DA CLASSE
            public Filhos[] filhos = new Filhos[10];
            int qtdfilhos=0;
            public int invalidos;
            public string DataAdmissao, CarteiraTrabalho;
        //##################################   
        //METODOS DA CLASSE
            public void InsereFilho(Form f, string Nome, string RG, string CPF, string dtnasc, bool invalidez, ListBox filho)
            {
                if (qtdfilhos < 10)
                {
                    filhos[qtdfilhos] = new Filhos();
                    filhos[qtdfilhos].Nome = Nome;
                    filhos[qtdfilhos].CPF = CPF;
                    filhos[qtdfilhos].RG = RG;
                    filhos[qtdfilhos].dtnasc = dtnasc;
                    filhos[qtdfilhos].invalidez = invalidez;
                    qtdfilhos++;
                    filho.Items.Add(Nome);
                }
                else
                    MessageBox.Show("Quantidade maxima de Filhos excedida");
            }
        //#####################
    }
}
