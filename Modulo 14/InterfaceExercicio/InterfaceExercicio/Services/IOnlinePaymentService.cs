namespace InterfaceExercicio.Services
{
    interface IOnlinePaymentService
    {
         double PaymentFree(double amount);
         double interest(double amount, int months);
    }
}
