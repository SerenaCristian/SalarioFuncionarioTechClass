using System;


namespace SalarioFuncionarioTechClass
{
    public class Salario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double porcentagem;


        public double CalculaSalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * Imposto / 100); ; 
        }

        public double AumentaSalario()
        {
            return SalarioBruto + SalarioBruto * porcentagem / 100.00;
        }
    }
}
