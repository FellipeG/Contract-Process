using ContractProcess.Entities;
using ContractProcess.Services;
using System;
using System.Globalization;

namespace ContractProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, contractValue);
            ContractService cService = new ContractService(new PaypalTaxService());
            cService.ProcessContract(contract, installmentsNumber);
            Console.WriteLine();
            Console.WriteLine("INSTALLMENTS:");
            Console.WriteLine(contract);

        }

    }
}