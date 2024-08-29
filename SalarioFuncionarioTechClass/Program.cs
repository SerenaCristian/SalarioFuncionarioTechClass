using System;

namespace SalarioFuncionarioTechClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Salario funcionario = new Salario();
            string sep = new string('.', 50);
            Console.WriteLine(sep);
            Console.WriteLine("Programa Calcula Salario Funcionário");
            Console.WriteLine(sep);

            Console.Write("Digite o nome do Funcionario: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Digite o salario bruto do Funcionario: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            
            Console.WriteLine(sep);
            
            Console.WriteLine("Dados do funcionário Atualizado: ");
            Console.WriteLine($"Nome Funcionário: {funcionario.Nome}");
            Console.WriteLine($"Salario Bruto Funcionário: {funcionario.SalarioBruto}");
            Console.WriteLine($"Salario liquido do Funcionário: {funcionario.CalculaSalarioLiquido()}");
        }
    }
}
