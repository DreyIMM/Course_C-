using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExercicio.Entities;
namespace InterfaceExercicio.Services
{
    internal class ContractService
    {
        public int QtdInments { get; set; }

        private IOnlinePaymentService _OnlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService, int qtdInments)
        {
            _OnlinePaymentService = onlinePaymentService;
            QtdInments = qtdInments;
        }

        public void ProcessContract(Contracts contract, int months)
        {
                       
            for (int i = 1; i <= QtdInments; i++)
            {
                months++;
                DateTime oka = new DateTime(contract.Date.Day, contract.Date.Month, contract.Date.Year);

                
               
                double value = _OnlinePaymentService.Interest(contract.TotalValue, months);
                                
                
                contract.Installment = new Installment(oka, value);
                contract.Installment.DueDate.AddMonths(months);
                Console.WriteLine(contract.Installment);
            }

        }

    }
}
