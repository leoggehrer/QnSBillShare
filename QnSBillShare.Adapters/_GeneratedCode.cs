namespace QnSBillShare.Adapters
{
	public static partial class Factory
	{
		public static Contracts.Client.IAdapterAccess<I> Create<I>() where I : Contracts.IIdentifiable
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IBill))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.App.IBill>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IExpense))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.App.IExpense>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.ILoginSession))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.Account.ILoginSession>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IRole))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.Account.IRole>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUser))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.Account.IUser>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUserXRole))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Persistence.Account.IUserXRole>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Business.App.IBillExpense))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Business.App.IBillExpense>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Business.Account.ILoginUser))
				{
					result = new Controller.GenericControllerAdapter<QnSBillShare.Contracts.Business.Account.ILoginUser>() as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IBill))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.App.IBill, Transfer.Persistence.App.Bill>(BaseUri, "Bill") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IExpense))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.App.IExpense, Transfer.Persistence.App.Expense>(BaseUri, "Expense") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.ILoginSession))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.Account.ILoginSession, Transfer.Persistence.Account.LoginSession>(BaseUri, "LoginSession") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IRole))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.Account.IRole, Transfer.Persistence.Account.Role>(BaseUri, "Role") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUser))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.Account.IUser, Transfer.Persistence.Account.User>(BaseUri, "User") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUserXRole))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Persistence.Account.IUserXRole, Transfer.Persistence.Account.UserXRole>(BaseUri, "UserXRole") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Business.App.IBillExpense))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Business.App.IBillExpense, Transfer.Business.App.BillExpense>(BaseUri, "BillExpense") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSBillShare.Contracts.Business.Account.ILoginUser))
				{
					result = new Service.GenericServiceAdapter<QnSBillShare.Contracts.Business.Account.ILoginUser, Transfer.Business.Account.LoginUser>(BaseUri, "LoginUser") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
	}
}
