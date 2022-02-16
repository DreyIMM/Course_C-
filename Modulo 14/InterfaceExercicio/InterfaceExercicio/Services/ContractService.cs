using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExercicio.Entities;
namespace InterfaceExercicio.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _OnlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _OnlinePaymentService = onlinePaymentService;
           
        }

        public void ProcessContract(Contracts contract, int months)
        {
            //Valor limpo no mês sem taxas 
            double basicQuota = contract.TotalValue / months ;
            
            for (int i = 1; i <= months; i++)
            {              
                DateTime date = contract.Date.AddMonths(i);
                               
                
                double updateQuota = basicQuota + _OnlinePaymentService.Interest(basicQuota,i);
                double fullQuta = updateQuota + _OnlinePaymentService.PaymentFree(updateQuota);
                
                
                contract.AddInstallment(new Installment(date, fullQuta));                               
            }

        }

    }
}
