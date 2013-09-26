using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_Bimestral
{
    public class EmpregadoMensal:Empregado
    {
        public float SalarioMensal, HorasExtras;
        float CalculaFaltas(float faltas) 
        { 
            return (faltas * (SalarioMensal / 30)); 
        }
        float CalculaHorasExtras()
        {
            return (HorasExtras * ((SalarioMensal / 30) / 8));
        }
        public double CalcularInss(float bruto)
        {
            double inss;
            if (bruto < 911.7) 
            { 
                inss = (bruto * 0.08); 
            } 
            else if ((bruto > 911.7) && (bruto < 1519.5)) 
            { 
                inss = (bruto * 0.09);
            } 
            else if ((bruto > 1519) && (bruto < 3038.99)) 
            { 
                inss = (bruto * 0.11); 
            } 
            else { inss = 3038.99 * 0.11; } 
            return inss; 
        } 
        //public float CalculaSalarioBruto(float bruto) 
        //{ 
        //    bruto = SalarioMensal + CalculaHoras() - CalculaFalta(); 
        //    return bruto; 
        //} 
        //public float CalculaSalarioFamilia() 
        //{ 
        //    return SalarioMensal; 
        //} 
        //public double CalcularSalarioLiquido() 
        //{ 
        //    return bruto - inss + CalculaSalarioFamilia(); 
        //} 
        
        

    }
}
