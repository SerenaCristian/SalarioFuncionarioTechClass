using System;

namespace SalarioFuncionarioTechClass
{
    public class Salario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double Porcentagem { get; set; }

        public Salario(string nome, double salarioBruto, double imposto, double porcentagem)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
            Porcentagem = porcentagem;
        }

        public double CalculaSalarioLiquido()
        {
            return SalarioBruto - (SalarioBruto * Imposto / 100);
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100;
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
