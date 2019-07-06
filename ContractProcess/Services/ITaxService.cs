namespace ContractProcess.Services
{
    interface ITaxService
    {
        double[] Tax(double value, int installments);
    }
}
