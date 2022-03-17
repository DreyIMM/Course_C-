using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulticastDelegate.Services;
namespace MulticastDelegate
{
    //declarando o delegate
    delegate void BinaryNumericOpertion(double n1,double n2);

    internal class Program
    {
        static void Main(string[] args)
        {


            double a = 10;
            double b = 12;

            BinaryNumericOpertion op = CalculationService.ShowSum;

            //Multicast
            op += CalculationService.ShowMax;

            op.Invoke(a, b);

            //Invocando um Multicast delegate com o Invoke

        }
    }
}
