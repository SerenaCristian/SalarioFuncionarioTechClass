using System;


namespace SalarioFuncionarioTechClass
{
    public class Salario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Porcentagem;

        public Salario(string nome, double salarioBruto, double imposto, double porcentagem)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
            Porcentagem = porcentagem;
        }

        public double CalculaSalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * Imposto / 100); ; 
        }

        public double AumentaSalario(double porcentagem)
        {
            return SalarioBruto + SalarioBruto * porcentagem / 100.00;
        }

        public override string ToString()
        {
            return $"Nome do Funcionário: {Nome}\n" +
                   $"Salário Bruto: {SalarioBruto:F2}\n" +
                   $"Imposto: {Imposto:F2}%\n" +
                   $"Salário Líquido: {CalculaSalarioLiquido():F2}";
        }

    }
}
