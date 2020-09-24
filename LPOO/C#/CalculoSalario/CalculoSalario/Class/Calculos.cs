using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    class Calculos
    {
        public double Salario; //Calcula Salario fixo + Comissão
        public double ImpostoINSS; //Armazena INSS

        public double CalculoImposto()
        {

            if (Salario <= 1751.81)//INSS 8%
            {
                return ImpostoINSS = Salario * 0.08;
                
                //isento de imposto de renda
            }
            else 
                if (Salario > 1751.81 && Salario < 2919.72)//INSS 9%
                {
                    if (Salario < 1903.98)
                    {
                        return ImpostoINSS = Salario * 0.09;
                        //isento de imposto de renda
                    }
                    else if (Salario > 1903.98 && Salario < 2826.65)
                    {
                        ImpostoINSS = Salario * 0.09;//Calculo INSS
                    return ImpostoINSS + (Salario * 0.075); //IR 7,5%
                    }
                    else
                    {
                        ImpostoINSS = Salario * 0.09;// Calculo INSS
                        return ImpostoINSS + (Salario * 0.15);//IR 15%
                    }

                }
                else
                {
                    if (Salario > 2919.72 && Salario < 5839.45)//INSS 11%
                    {
                        if (Salario > 2826.66 && Salario < 3751.05)
                        {
                            ImpostoINSS = Salario * 0.11;// Calculo INSS
                            return ImpostoINSS + (Salario * 0.15);//IR 15%
                        }
                        else if (Salario > 3751.06 && Salario < 4664.68)
                        {
                            ImpostoINSS = Salario * 0.11;// Calculo INSS
                            return ImpostoINSS + (Salario * 0.225);//IR 22,5%
                        }
                        else
                        {
                            ImpostoINSS = Salario * 0.11;// Calculo INSS
                            return ImpostoINSS + (Salario * 0.275);//IR 27,5%
                        }
                    }
                    else //INSS TETO
                    {
                        ImpostoINSS = 570.88;
                        return ImpostoINSS + Salario * 0.275;//IR 27,5%
                    }
            }
      
        }

        public double CalculoSalario(double SalFixo, double Vendas)
        {
            return (SalFixo + CalculoComissao(Vendas)) - CalculoImposto();//salario final
        }

        public double CalculoComissao(double Vendas)
        {
            
             /* 
             Modo longo:
             if(Vendas <= 10000)
             {
                 return Vendas * 0.05;
             }
             else if(Vendas >= 20000)
             {
                 return Vendas * 0.07;
             }
             else if(Vendas > 10000 && Vendas < 20000)
             {
                 return Vendas * 0.06;
             }
             else
             {
                 return 0;
             }
             Modo curto:
             */
             
            return Vendas <= 10000 ? Vendas * 0.05 : Vendas >= 20000 ? Vendas * 0.07 : Vendas < 20000 && Vendas > 10000 ? Vendas * 0.06 : 0;
        }

    }
}
