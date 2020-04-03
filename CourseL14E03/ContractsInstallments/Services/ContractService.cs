using System;
using ContractsInstallments.Entities;

namespace ContractsInstallments.Services
{
    class ContractService
    {
        private IOnlinePaymentService onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this.onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double baseAmount = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double installmentAmount = baseAmount + onlinePaymentService.Interest(baseAmount, i);
                installmentAmount += onlinePaymentService.PaymentFee(installmentAmount);

                contract.AddInstallment(new Installment(dueDate, installmentAmount));
            }
        }
    }
}
