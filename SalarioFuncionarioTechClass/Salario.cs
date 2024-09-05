using System;

namespace SalarioFuncionarioTechClass
{
    public class Salario
    {
        private string _nome;
        private double _salarioBruto;
        private double _imposto;
        private double _porcentagem;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double SalarioBruto
        {
            get { return _salarioBruto; }
            set { _salarioBruto = value; }
        }

        public double Imposto
        {
            get { return _imposto; }
            set { _imposto = value; }
        }

        public double Porcentagem
        {
            get { return _porcentagem; }
            set { _porcentagem = value; }
        }

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

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.00;
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



       