//MdStart
using QnSBillShare.Logic.DataContext;

namespace QnSBillShare.Logic.Controllers.Persistence
{
    internal abstract partial class QnSBillShareController<I, E> : GenericController<I, E>
       where I : Contracts.IIdentifiable
       where E : Entities.IdentityObject, I, Contracts.ICopyable<I>, new()
    {
        internal IQnSBillShareContext QnSBillShareContext => (IQnSBillShareContext)Context;

        protected QnSBillShareController(IContext context)
            : base(context)
        {
        }
        protected QnSBillShareController(ControllerObject controller)
            : base(controller)
        {
        }
    }
}
//MdEnd
