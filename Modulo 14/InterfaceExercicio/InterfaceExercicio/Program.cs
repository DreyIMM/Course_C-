using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using InterfaceExercicio.Entities;
using InterfaceExercicio.Services;
namespace InterfaceExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - Entre com os dados do contratos - - ");
            Console.Write("Numero ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/YYYY) ");
            DateTime datContract = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato ");
            double valueContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de parcelas ");
            int qtdInments = int.Parse(Console.ReadLine());

             
            Contracts myContract = new Contracts(num, datContract, valueContract);
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(myContract,qtdInments);

            
          
            
        
            
            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments) {
                Console.WriteLine(installment);
            }         
            qtdInments = int.Parse(Console.ReadLine());
        }
    }
}
