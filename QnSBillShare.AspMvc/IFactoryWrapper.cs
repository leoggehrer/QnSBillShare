using QnSBillShare.Contracts;
using QnSBillShare.Contracts.Client;

namespace QnSBillShare.AspMvc
{
    public interface IFactoryWrapper
    {
        IAdapterAccess<I> Create<I>() where I : IIdentifiable;
    }
}