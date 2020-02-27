//@QnSCodeCopy
//MdStart
using System.Collections.Generic;
using QnSBillShare.Contracts.Persistence.Account;

namespace QnSBillShare.Contracts.Business.Account
{
    public partial interface ILoginUser : IIdentifiable, ICopyable<ILoginUser>
    {
        IUser User { get; }
        IEnumerable<IRole> Roles { get; }

        IRole CreateRole();
        void AddRole(IRole role);
        void RemoveRole(IRole role);
    }
}
//MdEnd
