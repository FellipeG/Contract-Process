using System;
using System.Globalization;

namespace ContractProcess.Entities
{
    class Installment
    {
        public DateTime Date { get; private set; }
        public double Value { get; private set; }

        public Installment(DateTime date, double value)
        {
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy") + " - " + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
