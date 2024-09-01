using System;

namespace SalarioFuncionarioTechClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string sep = new string('.', 50);
            Console.WriteLine(sep);
            Console.WriteLine("Programa Calcula Salario Funcionário");
            Console.WriteLine(sep);

            Console.Write("Digite o nome do Funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o salario bruto do Funcionario: ");
           double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do imposto: ");
            double imposto = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine(sep);

            Salario funcionario = new Salario(nome, salarioBruto, imposto, porcentagem);

            Console.WriteLine(funcionario);

        }
    }
}
