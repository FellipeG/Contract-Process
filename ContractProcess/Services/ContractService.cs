using System;
using ContractProcess.Entities;

namespace ContractProcess.Services
{
    class ContractService
    {
        private ITaxService _taxService;

        public ContractService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.Value / months;
            for(int i=1; i<=months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _taxService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _taxService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
