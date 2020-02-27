namespace QnSBillShare.Logic.DataContext.Db
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	partial class QnSBillShareDbContext : GenericDbContext
	{
		protected DbSet<Entities.Persistence.App.Bill> BillSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.App.Expense> ExpenseSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.LoginSession> LoginSessionSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.Role> RoleSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.User> UserSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.UserXRole> UserXRoleSet
		{
			get;
			set;
		}
		public override DbSet<E> Set<I, E>()
		{
			DbSet<E> result = null;
			if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IBill))
			{
				result = BillSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.App.IExpense))
			{
				result = ExpenseSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.ILoginSession))
			{
				result = LoginSessionSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IRole))
			{
				result = RoleSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUser))
			{
				result = UserSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSBillShare.Contracts.Persistence.Account.IUserXRole))
			{
				result = UserXRoleSet as DbSet<E>;
			}
			return result;
		}
		partial void DoModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Entities.Persistence.App.Bill>().ToTable(nameof(Entities.Persistence.App.Bill), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Bill.Id));
			modelBuilder.Entity<Entities.Persistence.App.Bill>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Bill>());
			modelBuilder.Entity<Entities.Persistence.App.Expense>().ToTable(nameof(Entities.Persistence.App.Expense), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Expense.Id));
			modelBuilder.Entity<Entities.Persistence.App.Expense>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Expense>());
			modelBuilder.Entity<Entities.Persistence.Account.LoginSession>().ToTable(nameof(Entities.Persistence.Account.LoginSession), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.LoginSession.Id));
			modelBuilder.Entity<Entities.Persistence.Account.LoginSession>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.LoginSession>());
			modelBuilder.Entity<Entities.Persistence.Account.Role>().ToTable(nameof(Entities.Persistence.Account.Role), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.Role.Id));
			modelBuilder.Entity<Entities.Persistence.Account.Role>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.Role>());
			modelBuilder.Entity<Entities.Persistence.Account.User>().ToTable(nameof(Entities.Persistence.Account.User), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.User.Id));
			modelBuilder.Entity<Entities.Persistence.Account.User>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.User>());
			modelBuilder.Entity<Entities.Persistence.Account.UserXRole>().ToTable(nameof(Entities.Persistence.Account.UserXRole), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.UserXRole.Id));
			modelBuilder.Entity<Entities.Persistence.Account.UserXRole>().Property(p => p.Timestamp).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.UserXRole>());
		}
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Bill> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Expense> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.LoginSession> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Role> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.User> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.UserXRole> entityTypeBuilder);
	}
}
