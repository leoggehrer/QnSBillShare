namespace QnSBillShare.Logic.Entities.Persistence.App
{
	using System;
	partial class Bill : QnSBillShare.Contracts.Persistence.App.IBill
	{
		static Bill()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Bill()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.DateTime Date
		{
			get
			{
				OnDateReading();
				return _date;
			}
			set
			{
				bool handled = false;
				OnDateChanging(ref handled, ref _date);
				if (handled == false)
				{
					this._date = value;
				}
				OnDateChanged();
			}
		}
		private System.DateTime _date;
		partial void OnDateReading();
		partial void OnDateChanging(ref bool handled, ref System.DateTime _date);
		partial void OnDateChanged();
		public System.String Title
		{
			get
			{
				OnTitleReading();
				return _title;
			}
			set
			{
				bool handled = false;
				OnTitleChanging(ref handled, ref _title);
				if (handled == false)
				{
					this._title = value;
				}
				OnTitleChanged();
			}
		}
		private System.String _title;
		partial void OnTitleReading();
		partial void OnTitleChanging(ref bool handled, ref System.String _title);
		partial void OnTitleChanged();
		public System.String Description
		{
			get
			{
				OnDescriptionReading();
				return _description;
			}
			set
			{
				bool handled = false;
				OnDescriptionChanging(ref handled, ref _description);
				if (handled == false)
				{
					this._description = value;
				}
				OnDescriptionChanged();
			}
		}
		private System.String _description;
		partial void OnDescriptionReading();
		partial void OnDescriptionChanging(ref bool handled, ref System.String _description);
		partial void OnDescriptionChanged();
		public System.String Currency
		{
			get
			{
				OnCurrencyReading();
				return _currency;
			}
			set
			{
				bool handled = false;
				OnCurrencyChanging(ref handled, ref _currency);
				if (handled == false)
				{
					this._currency = value;
				}
				OnCurrencyChanged();
			}
		}
		private System.String _currency;
		partial void OnCurrencyReading();
		partial void OnCurrencyChanging(ref bool handled, ref System.String _currency);
		partial void OnCurrencyChanged();
		public System.String Friends
		{
			get
			{
				OnFriendsReading();
				return _friends;
			}
			set
			{
				bool handled = false;
				OnFriendsChanging(ref handled, ref _friends);
				if (handled == false)
				{
					this._friends = value;
				}
				OnFriendsChanged();
			}
		}
		private System.String _friends;
		partial void OnFriendsReading();
		partial void OnFriendsChanging(ref bool handled, ref System.String _friends);
		partial void OnFriendsChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.App.IBill other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Date = other.Date;
				Title = other.Title;
				Description = other.Description;
				Currency = other.Currency;
				Friends = other.Friends;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.App.IBill other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.App.IBill other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.App.IBill instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.App.IBill other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && Date == other.Date && IsEqualsWith(Title, other.Title) && IsEqualsWith(Description, other.Description) && IsEqualsWith(Currency, other.Currency) && IsEqualsWith(Friends, other.Friends);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Date, Title, Description, Currency, HashCode.Combine(Friends));
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.App
{
	partial class Bill : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.App
{
	partial class Bill
	{
		public System.Collections.Generic.ICollection<QnSBillShare.Logic.Entities.Persistence.App.Expense> Expenses
		{
			get;
			set;
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.App
{
	using System;
	partial class Expense : QnSBillShare.Contracts.Persistence.App.IExpense
	{
		static Expense()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Expense()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 BillId
		{
			get
			{
				OnBillIdReading();
				return _billId;
			}
			set
			{
				bool handled = false;
				OnBillIdChanging(ref handled, ref _billId);
				if (handled == false)
				{
					this._billId = value;
				}
				OnBillIdChanged();
			}
		}
		private System.Int32 _billId;
		partial void OnBillIdReading();
		partial void OnBillIdChanging(ref bool handled, ref System.Int32 _billId);
		partial void OnBillIdChanged();
		public System.String Designation
		{
			get
			{
				OnDesignationReading();
				return _designation;
			}
			set
			{
				bool handled = false;
				OnDesignationChanging(ref handled, ref _designation);
				if (handled == false)
				{
					this._designation = value;
				}
				OnDesignationChanged();
			}
		}
		private System.String _designation;
		partial void OnDesignationReading();
		partial void OnDesignationChanging(ref bool handled, ref System.String _designation);
		partial void OnDesignationChanged();
		public System.Double Amount
		{
			get
			{
				OnAmountReading();
				return _amount;
			}
			set
			{
				bool handled = false;
				OnAmountChanging(ref handled, ref _amount);
				if (handled == false)
				{
					this._amount = value;
				}
				OnAmountChanged();
			}
		}
		private System.Double _amount;
		partial void OnAmountReading();
		partial void OnAmountChanging(ref bool handled, ref System.Double _amount);
		partial void OnAmountChanged();
		public System.String Friend
		{
			get
			{
				OnFriendReading();
				return _friend;
			}
			set
			{
				bool handled = false;
				OnFriendChanging(ref handled, ref _friend);
				if (handled == false)
				{
					this._friend = value;
				}
				OnFriendChanged();
			}
		}
		private System.String _friend;
		partial void OnFriendReading();
		partial void OnFriendChanging(ref bool handled, ref System.String _friend);
		partial void OnFriendChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.App.IExpense other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				BillId = other.BillId;
				Designation = other.Designation;
				Amount = other.Amount;
				Friend = other.Friend;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.App.IExpense other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.App.IExpense other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.App.IExpense instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.App.IExpense other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && BillId == other.BillId && IsEqualsWith(Designation, other.Designation) && Amount == other.Amount && IsEqualsWith(Friend, other.Friend);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, BillId, Designation, Amount, Friend);
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.App
{
	partial class Expense : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.App
{
	partial class Expense
	{
		public QnSBillShare.Logic.Entities.Persistence.App.Bill Bill
		{
			get;
			set;
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	using System;
	partial class LoginSession : QnSBillShare.Contracts.Persistence.Account.ILoginSession
	{
		static LoginSession()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public LoginSession()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 UserId
		{
			get
			{
				OnUserIdReading();
				return _userId;
			}
			set
			{
				bool handled = false;
				OnUserIdChanging(ref handled, ref _userId);
				if (handled == false)
				{
					this._userId = value;
				}
				OnUserIdChanged();
			}
		}
		private System.Int32 _userId;
		partial void OnUserIdReading();
		partial void OnUserIdChanging(ref bool handled, ref System.Int32 _userId);
		partial void OnUserIdChanged();
		public System.String SessionToken
		{
			get
			{
				OnSessionTokenReading();
				return _sessionToken;
			}
			set
			{
				bool handled = false;
				OnSessionTokenChanging(ref handled, ref _sessionToken);
				if (handled == false)
				{
					this._sessionToken = value;
				}
				OnSessionTokenChanged();
			}
		}
		private System.String _sessionToken;
		partial void OnSessionTokenReading();
		partial void OnSessionTokenChanging(ref bool handled, ref System.String _sessionToken);
		partial void OnSessionTokenChanged();
		public System.DateTime LoginTime
		{
			get
			{
				OnLoginTimeReading();
				return _loginTime;
			}
			set
			{
				bool handled = false;
				OnLoginTimeChanging(ref handled, ref _loginTime);
				if (handled == false)
				{
					this._loginTime = value;
				}
				OnLoginTimeChanged();
			}
		}
		private System.DateTime _loginTime;
		partial void OnLoginTimeReading();
		partial void OnLoginTimeChanging(ref bool handled, ref System.DateTime _loginTime);
		partial void OnLoginTimeChanged();
		public System.DateTime LastAccess
		{
			get
			{
				OnLastAccessReading();
				return _lastAccess;
			}
			set
			{
				bool handled = false;
				OnLastAccessChanging(ref handled, ref _lastAccess);
				if (handled == false)
				{
					this._lastAccess = value;
				}
				OnLastAccessChanged();
			}
		}
		private System.DateTime _lastAccess;
		partial void OnLastAccessReading();
		partial void OnLastAccessChanging(ref bool handled, ref System.DateTime _lastAccess);
		partial void OnLastAccessChanged();
		public System.DateTime? LogoutTime
		{
			get
			{
				OnLogoutTimeReading();
				return _logoutTime;
			}
			set
			{
				bool handled = false;
				OnLogoutTimeChanging(ref handled, ref _logoutTime);
				if (handled == false)
				{
					this._logoutTime = value;
				}
				OnLogoutTimeChanged();
			}
		}
		private System.DateTime? _logoutTime;
		partial void OnLogoutTimeReading();
		partial void OnLogoutTimeChanging(ref bool handled, ref System.DateTime? _logoutTime);
		partial void OnLogoutTimeChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.Account.ILoginSession other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				UserId = other.UserId;
				SessionToken = other.SessionToken;
				LoginTime = other.LoginTime;
				LastAccess = other.LastAccess;
				LogoutTime = other.LogoutTime;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.Account.ILoginSession other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.Account.ILoginSession other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.Account.ILoginSession instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.Account.ILoginSession other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && UserId == other.UserId && IsEqualsWith(SessionToken, other.SessionToken) && LoginTime == other.LoginTime && LastAccess == other.LastAccess && LogoutTime == other.LogoutTime;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, UserId, SessionToken, LoginTime, LastAccess, HashCode.Combine(LogoutTime));
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class LoginSession : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class LoginSession
	{
		public QnSBillShare.Logic.Entities.Persistence.Account.User User
		{
			get;
			set;
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	using System;
	partial class Role : QnSBillShare.Contracts.Persistence.Account.IRole
	{
		static Role()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public Role()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String Designation
		{
			get
			{
				OnDesignationReading();
				return _designation;
			}
			set
			{
				bool handled = false;
				OnDesignationChanging(ref handled, ref _designation);
				if (handled == false)
				{
					this._designation = value;
				}
				OnDesignationChanged();
			}
		}
		private System.String _designation;
		partial void OnDesignationReading();
		partial void OnDesignationChanging(ref bool handled, ref System.String _designation);
		partial void OnDesignationChanged();
		public System.String Description
		{
			get
			{
				OnDescriptionReading();
				return _description;
			}
			set
			{
				bool handled = false;
				OnDescriptionChanging(ref handled, ref _description);
				if (handled == false)
				{
					this._description = value;
				}
				OnDescriptionChanged();
			}
		}
		private System.String _description;
		partial void OnDescriptionReading();
		partial void OnDescriptionChanging(ref bool handled, ref System.String _description);
		partial void OnDescriptionChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.Account.IRole other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Designation = other.Designation;
				Description = other.Description;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.Account.IRole other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.Account.IRole other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.Account.IRole instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.Account.IRole other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Designation, other.Designation) && IsEqualsWith(Description, other.Description);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Designation, Description);
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class Role : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class Role
	{
		public System.Collections.Generic.ICollection<QnSBillShare.Logic.Entities.Persistence.Account.UserXRole> UserXRoles
		{
			get;
			set;
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	using System;
	partial class User : QnSBillShare.Contracts.Persistence.Account.IUser
	{
		static User()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public User()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.String UserName
		{
			get
			{
				OnUserNameReading();
				return _userName;
			}
			set
			{
				bool handled = false;
				OnUserNameChanging(ref handled, ref _userName);
				if (handled == false)
				{
					this._userName = value;
				}
				OnUserNameChanged();
			}
		}
		private System.String _userName;
		partial void OnUserNameReading();
		partial void OnUserNameChanging(ref bool handled, ref System.String _userName);
		partial void OnUserNameChanged();
		public System.String Password
		{
			get
			{
				OnPasswordReading();
				return _password;
			}
			set
			{
				bool handled = false;
				OnPasswordChanging(ref handled, ref _password);
				if (handled == false)
				{
					this._password = value;
				}
				OnPasswordChanged();
			}
		}
		private System.String _password;
		partial void OnPasswordReading();
		partial void OnPasswordChanging(ref bool handled, ref System.String _password);
		partial void OnPasswordChanged();
		public System.String Email
		{
			get
			{
				OnEmailReading();
				return _email;
			}
			set
			{
				bool handled = false;
				OnEmailChanging(ref handled, ref _email);
				if (handled == false)
				{
					this._email = value;
				}
				OnEmailChanged();
			}
		}
		private System.String _email;
		partial void OnEmailReading();
		partial void OnEmailChanging(ref bool handled, ref System.String _email);
		partial void OnEmailChanged();
		public System.String FirstName
		{
			get
			{
				OnFirstNameReading();
				return _firstName;
			}
			set
			{
				bool handled = false;
				OnFirstNameChanging(ref handled, ref _firstName);
				if (handled == false)
				{
					this._firstName = value;
				}
				OnFirstNameChanged();
			}
		}
		private System.String _firstName;
		partial void OnFirstNameReading();
		partial void OnFirstNameChanging(ref bool handled, ref System.String _firstName);
		partial void OnFirstNameChanged();
		public System.String LastName
		{
			get
			{
				OnLastNameReading();
				return _lastName;
			}
			set
			{
				bool handled = false;
				OnLastNameChanging(ref handled, ref _lastName);
				if (handled == false)
				{
					this._lastName = value;
				}
				OnLastNameChanged();
			}
		}
		private System.String _lastName;
		partial void OnLastNameReading();
		partial void OnLastNameChanging(ref bool handled, ref System.String _lastName);
		partial void OnLastNameChanged();
		public System.String PhoneNumber
		{
			get
			{
				OnPhoneNumberReading();
				return _phoneNumber;
			}
			set
			{
				bool handled = false;
				OnPhoneNumberChanging(ref handled, ref _phoneNumber);
				if (handled == false)
				{
					this._phoneNumber = value;
				}
				OnPhoneNumberChanged();
			}
		}
		private System.String _phoneNumber;
		partial void OnPhoneNumberReading();
		partial void OnPhoneNumberChanging(ref bool handled, ref System.String _phoneNumber);
		partial void OnPhoneNumberChanged();
		public System.Byte[] Avatar
		{
			get
			{
				OnAvatarReading();
				return _avatar;
			}
			set
			{
				bool handled = false;
				OnAvatarChanging(ref handled, ref _avatar);
				if (handled == false)
				{
					this._avatar = value;
				}
				OnAvatarChanged();
			}
		}
		private System.Byte[] _avatar;
		partial void OnAvatarReading();
		partial void OnAvatarChanging(ref bool handled, ref System.Byte[] _avatar);
		partial void OnAvatarChanged();
		public System.String AvatarMimeType
		{
			get
			{
				OnAvatarMimeTypeReading();
				return _avatarMimeType;
			}
			set
			{
				bool handled = false;
				OnAvatarMimeTypeChanging(ref handled, ref _avatarMimeType);
				if (handled == false)
				{
					this._avatarMimeType = value;
				}
				OnAvatarMimeTypeChanged();
			}
		}
		private System.String _avatarMimeType;
		partial void OnAvatarMimeTypeReading();
		partial void OnAvatarMimeTypeChanging(ref bool handled, ref System.String _avatarMimeType);
		partial void OnAvatarMimeTypeChanged();
		public QnSBillShare.Contracts.State State
		{
			get
			{
				OnStateReading();
				return _state;
			}
			set
			{
				bool handled = false;
				OnStateChanging(ref handled, ref _state);
				if (handled == false)
				{
					this._state = value;
				}
				OnStateChanged();
			}
		}
		private QnSBillShare.Contracts.State _state;
		partial void OnStateReading();
		partial void OnStateChanging(ref bool handled, ref QnSBillShare.Contracts.State _state);
		partial void OnStateChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.Account.IUser other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				UserName = other.UserName;
				Password = other.Password;
				Email = other.Email;
				FirstName = other.FirstName;
				LastName = other.LastName;
				PhoneNumber = other.PhoneNumber;
				Avatar = other.Avatar;
				AvatarMimeType = other.AvatarMimeType;
				State = other.State;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.Account.IUser other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.Account.IUser other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.Account.IUser instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.Account.IUser other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(UserName, other.UserName) && IsEqualsWith(Password, other.Password) && IsEqualsWith(Email, other.Email) && IsEqualsWith(FirstName, other.FirstName) && IsEqualsWith(LastName, other.LastName) && IsEqualsWith(PhoneNumber, other.PhoneNumber) && IsEqualsWith(Avatar, other.Avatar) && IsEqualsWith(AvatarMimeType, other.AvatarMimeType) && State == other.State;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, UserName, Password, Email, FirstName, HashCode.Combine(LastName, PhoneNumber, Avatar, AvatarMimeType, State));
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class User : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class User
	{
		public System.Collections.Generic.ICollection<QnSBillShare.Logic.Entities.Persistence.Account.LoginSession> LoginSessions
		{
			get;
			set;
		}
		public System.Collections.Generic.ICollection<QnSBillShare.Logic.Entities.Persistence.Account.UserXRole> UserXRoles
		{
			get;
			set;
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	using System;
	partial class UserXRole : QnSBillShare.Contracts.Persistence.Account.IUserXRole
	{
		static UserXRole()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public UserXRole()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public System.Int32 UserId
		{
			get
			{
				OnUserIdReading();
				return _userId;
			}
			set
			{
				bool handled = false;
				OnUserIdChanging(ref handled, ref _userId);
				if (handled == false)
				{
					this._userId = value;
				}
				OnUserIdChanged();
			}
		}
		private System.Int32 _userId;
		partial void OnUserIdReading();
		partial void OnUserIdChanging(ref bool handled, ref System.Int32 _userId);
		partial void OnUserIdChanged();
		public System.Int32 RoleId
		{
			get
			{
				OnRoleIdReading();
				return _roleId;
			}
			set
			{
				bool handled = false;
				OnRoleIdChanging(ref handled, ref _roleId);
				if (handled == false)
				{
					this._roleId = value;
				}
				OnRoleIdChanged();
			}
		}
		private System.Int32 _roleId;
		partial void OnRoleIdReading();
		partial void OnRoleIdChanging(ref bool handled, ref System.Int32 _roleId);
		partial void OnRoleIdChanged();
		public void CopyProperties(QnSBillShare.Contracts.Persistence.Account.IUserXRole other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				UserId = other.UserId;
				RoleId = other.RoleId;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSBillShare.Contracts.Persistence.Account.IUserXRole other, ref bool handled);
		partial void AfterCopyProperties(QnSBillShare.Contracts.Persistence.Account.IUserXRole other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSBillShare.Contracts.Persistence.Account.IUserXRole instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSBillShare.Contracts.Persistence.Account.IUserXRole other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && UserId == other.UserId && RoleId == other.RoleId;
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, UserId, RoleId);
		}
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class UserXRole : IdentityObject
	{
	}
}
namespace QnSBillShare.Logic.Entities.Persistence.Account
{
	partial class UserXRole
	{
		public QnSBillShare.Logic.Entities.Persistence.Account.User User
		{
			get;
			set;
		}
		public QnSBillShare.Logic.Entities.Persistence.Account.Role Role
		{
			get;
			set;
		}
	}
}
