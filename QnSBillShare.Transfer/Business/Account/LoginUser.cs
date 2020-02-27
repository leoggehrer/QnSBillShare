//@QnSCodeCopy
//MdStart
using CommonBase.Extensions;
using QnSBillShare.Contracts.Persistence.Account;
using QnSBillShare.Transfer.Persistence.Account;

namespace QnSBillShare.Transfer.Business.Account
{
    partial class LoginUser
    {
        public IRole CreateRole()
        {
            return new Role();
        }
        public void AddRole(IRole role)
        {
            role.CheckArgument(nameof(role));
        }
        public void RemoveRole(IRole role)
        {
            role.CheckArgument(nameof(role));
        }
    }
}
//MdEnd
