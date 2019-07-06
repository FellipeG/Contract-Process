using System;
using System.Collections.Generic;
using System.Text;

namespace ContractProcess.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double Value { get; private set; }
        public List<Installment> Installments { get; private set; } = new List<Installment>();

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Installment installment in Installments)
            {
                sb.AppendLine(installment.ToString());
            }
            return sb.ToString();
        }
    }
}
