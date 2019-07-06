using System.Globalization;

namespace ContractProcess.Services
{
    class PaypalTaxService : ITaxService
    {
        public double[] Tax(double value, int installments)
        {
            double[] valuePerMonthVector = new double[installments];
            double v = (value / installments);
            for (int i=0;i<installments; i++)
            {
                double tax = double.Parse("1.0"+(i+1), CultureInfo.InvariantCulture);
                double valuePerMonth = (v * tax) * 1.02;
                valuePerMonthVector[i] =  valuePerMonth;
            }

            return valuePerMonthVector;
        }
    }
}
