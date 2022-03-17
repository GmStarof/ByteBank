using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;


namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "148.154.454-48";
            carlos.Salario = 2000;





            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());





            Console.ReadLine();
           

        }
    }
}
