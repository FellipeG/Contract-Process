namespace ContractProcess.Services
{
    interface ITaxService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
