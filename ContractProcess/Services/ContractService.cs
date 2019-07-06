using System;
using ContractProcess.Entities;

namespace ContractProcess.Services
{
    class ContractService
    {
        private ITaxService _taxService;
        private int _installmentsNumber;

        public ContractService(ITaxService taxService, int installmentsNumber)
        {
            _taxService = taxService;
            _installmentsNumber = installmentsNumber;
        }

        public void AddInstallment(Contract contract)
        {
            DateTime date = contract.Date;
            double[] installmentsValue = _taxService.Tax(contract.Value, _installmentsNumber);
            foreach (double monthValue in installmentsValue)
            {
                date = date.AddMonths(1);
                contract.AddInstallment(new Installment(date, monthValue));
            }
        }
    }
}
