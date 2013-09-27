using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_Bimestral
{
    public class EmpregadoMensal : Empregado,ICalcula_Salario_Bruto,ICalcula_Salario_Familia,ICalcula_Salario_Liquido,ICalcula_INSS
    {
        //ATRIBUTOS DA CLASSE
            public double SalarioMensal, HorasExtras, faltas;
        //#########
        //METODOS DA CLASSE
            double CalculaFaltas() 
            { 
                return (faltas * (SalarioMensal / 30)); 
            }
            double CalculaHorasExtras()
            {
                return (HorasExtras * ((SalarioMensal / 30) / 8));
            }
        //###################
        //METODOS HERDADOS DAS INTERFACES
            public double CalculaSalarioBruto()
            {
                return SalarioMensal + CalculaHorasExtras() - CalculaFaltas();
            }
            public double CalculaInss()
            {
                double inss;
                if (CalculaSalarioBruto() < 911.7) 
                {
                    inss = (CalculaSalarioBruto() * 0.08); 
                }
                else if ((CalculaSalarioBruto() > 911.7) && (CalculaSalarioBruto() < 1519.5)) 
                {
                    inss = (CalculaSalarioBruto() * 0.09);
                }
                else if ((CalculaSalarioBruto() > 1519) && (CalculaSalarioBruto() < 3038.99)) 
                {
                    inss = (CalculaSalarioBruto() * 0.11); 
                } 
                else { inss = 3038.99 * 0.11; } 
                return inss; 
            }
            public double CalculaSalarioFamilia() 
            { 
                double auxilio;
                if (CalculaSalarioBruto() < 646.55)
                {
                    auxilio = (invalidos * 33.16);
                }
                else if ((CalculaSalarioBruto() >= 646.55) && (CalculaSalarioBruto() < 971.78))
                {
                    auxilio = (invalidos * 23.36);
                }
                else 
                    auxilio = 0;
                return auxilio; 
            }
            public double CalculaSalarioLiquido() 
            { 
                return CalculaSalarioBruto() - CalculaInss() + CalculaSalarioFamilia(); 
            } 
        //##############                
    }
}
