using DTO;

namespace BLL
{
    public interface IPayOnlineTransactionManager
    {
        PayOnlineTransaction AddPayOnlineTransaction(PayOnlineTransaction payOnlineTransaction);
    }
}