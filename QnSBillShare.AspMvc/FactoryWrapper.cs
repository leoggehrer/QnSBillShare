using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QnSBillShare.AspMvc
{
    public class FactoryWrapper : IFactoryWrapper
    {
        public Contracts.Client.IAdapterAccess<I> Create<I>() where I : Contracts.IIdentifiable
        {
            return Adapters.Factory.Create<I>();
        }
    }
}
