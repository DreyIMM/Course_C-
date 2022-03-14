using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeDelagate.Services;
namespace TypeDelagate
{
    //declarando o Delegate
    //Referencia para um função com dois params
    //caso a assinatura da função passada seja diferente, terá erro
    delegate double BinaryNumericOperation(double n1, double n2);


    internal class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            //declarando um objeto Delegate

            //Meu delegate OP é uma referencia para função soma
            BinaryNumericOperation op = CalculationService.Sum;

            double resultDelegate = op(a, b);

            Console.WriteLine("Whit delegate " +resultDelegate);








        }
    }
}
