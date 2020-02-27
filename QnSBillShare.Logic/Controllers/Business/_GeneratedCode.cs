namespace QnSBillShare.Logic.Controllers.Business.App
{
	sealed partial class BillExpenseController : ControllerObject, Contracts.Client.IControllerAccess<QnSBillShare.Contracts.Business.App.IBillExpense>
	{
		static BillExpenseController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public BillExpenseController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public BillExpenseController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
namespace QnSBillShare.Logic.Controllers.Business.Account
{
	sealed partial class LoginUserController : ControllerObject, Contracts.Client.IControllerAccess<QnSBillShare.Contracts.Business.Account.ILoginUser>
	{
		static LoginUserController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public LoginUserController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public LoginUserController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
