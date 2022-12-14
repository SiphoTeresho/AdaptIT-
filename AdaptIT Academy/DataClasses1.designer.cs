#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdaptIT_Academy
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AdaptIT Academy")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAddress(Address instance);
    partial void UpdateAddress(Address instance);
    partial void DeleteAddress(Address instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertTraining(Training instance);
    partial void UpdateTraining(Training instance);
    partial void DeleteTraining(Training instance);
    partial void InsertDelegate(Delegate instance);
    partial void UpdateDelegate(Delegate instance);
    partial void DeleteDelegate(Delegate instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::AdaptIT_Academy.Properties.Settings.Default.AdaptIT_AcademyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Address> Addresses
		{
			get
			{
				return this.GetTable<Address>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<CourseTraining> CourseTrainings
		{
			get
			{
				return this.GetTable<CourseTraining>();
			}
		}
		
		public System.Data.Linq.Table<Training> Trainings
		{
			get
			{
				return this.GetTable<Training>();
			}
		}
		
		public System.Data.Linq.Table<Delegate> Delegates
		{
			get
			{
				return this.GetTable<Delegate>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Address")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AddressID;
		
		private int _DelegateID;
		
		private string _PhysicalAddressLine1;
		
		private string _PhysicalAddressLine2;
		
		private int _PhysicalAddressCode;
		
		private string _PostalAddressLine1;
		
		private string _PostalAddressLine2;
		
		private int _PostalAddressCode;
		
		private EntityRef<Delegate> _Delegate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAddressIDChanging(int value);
    partial void OnAddressIDChanged();
    partial void OnDelegateIDChanging(int value);
    partial void OnDelegateIDChanged();
    partial void OnPhysicalAddressLine1Changing(string value);
    partial void OnPhysicalAddressLine1Changed();
    partial void OnPhysicalAddressLine2Changing(string value);
    partial void OnPhysicalAddressLine2Changed();
    partial void OnPhysicalAddressCodeChanging(int value);
    partial void OnPhysicalAddressCodeChanged();
    partial void OnPostalAddressLine1Changing(string value);
    partial void OnPostalAddressLine1Changed();
    partial void OnPostalAddressLine2Changing(string value);
    partial void OnPostalAddressLine2Changed();
    partial void OnPostalAddressCodeChanging(int value);
    partial void OnPostalAddressCodeChanged();
    #endregion
		
		public Address()
		{
			this._Delegate = default(EntityRef<Delegate>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AddressID
		{
			get
			{
				return this._AddressID;
			}
			set
			{
				if ((this._AddressID != value))
				{
					this.OnAddressIDChanging(value);
					this.SendPropertyChanging();
					this._AddressID = value;
					this.SendPropertyChanged("AddressID");
					this.OnAddressIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DelegateID", DbType="Int NOT NULL")]
		public int DelegateID
		{
			get
			{
				return this._DelegateID;
			}
			set
			{
				if ((this._DelegateID != value))
				{
					if (this._Delegate.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDelegateIDChanging(value);
					this.SendPropertyChanging();
					this._DelegateID = value;
					this.SendPropertyChanged("DelegateID");
					this.OnDelegateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhysicalAddressLine1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PhysicalAddressLine1
		{
			get
			{
				return this._PhysicalAddressLine1;
			}
			set
			{
				if ((this._PhysicalAddressLine1 != value))
				{
					this.OnPhysicalAddressLine1Changing(value);
					this.SendPropertyChanging();
					this._PhysicalAddressLine1 = value;
					this.SendPropertyChanged("PhysicalAddressLine1");
					this.OnPhysicalAddressLine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhysicalAddressLine2", DbType="VarChar(50)")]
		public string PhysicalAddressLine2
		{
			get
			{
				return this._PhysicalAddressLine2;
			}
			set
			{
				if ((this._PhysicalAddressLine2 != value))
				{
					this.OnPhysicalAddressLine2Changing(value);
					this.SendPropertyChanging();
					this._PhysicalAddressLine2 = value;
					this.SendPropertyChanged("PhysicalAddressLine2");
					this.OnPhysicalAddressLine2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhysicalAddressCode", DbType="Int NOT NULL")]
		public int PhysicalAddressCode
		{
			get
			{
				return this._PhysicalAddressCode;
			}
			set
			{
				if ((this._PhysicalAddressCode != value))
				{
					this.OnPhysicalAddressCodeChanging(value);
					this.SendPropertyChanging();
					this._PhysicalAddressCode = value;
					this.SendPropertyChanged("PhysicalAddressCode");
					this.OnPhysicalAddressCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressLine1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PostalAddressLine1
		{
			get
			{
				return this._PostalAddressLine1;
			}
			set
			{
				if ((this._PostalAddressLine1 != value))
				{
					this.OnPostalAddressLine1Changing(value);
					this.SendPropertyChanging();
					this._PostalAddressLine1 = value;
					this.SendPropertyChanged("PostalAddressLine1");
					this.OnPostalAddressLine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressLine2", DbType="VarChar(50)")]
		public string PostalAddressLine2
		{
			get
			{
				return this._PostalAddressLine2;
			}
			set
			{
				if ((this._PostalAddressLine2 != value))
				{
					this.OnPostalAddressLine2Changing(value);
					this.SendPropertyChanging();
					this._PostalAddressLine2 = value;
					this.SendPropertyChanged("PostalAddressLine2");
					this.OnPostalAddressLine2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalAddressCode", DbType="Int NOT NULL")]
		public int PostalAddressCode
		{
			get
			{
				return this._PostalAddressCode;
			}
			set
			{
				if ((this._PostalAddressCode != value))
				{
					this.OnPostalAddressCodeChanging(value);
					this.SendPropertyChanging();
					this._PostalAddressCode = value;
					this.SendPropertyChanged("PostalAddressCode");
					this.OnPostalAddressCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Delegate_Address", Storage="_Delegate", ThisKey="DelegateID", OtherKey="DelegateID", IsForeignKey=true)]
		public Delegate Delegate
		{
			get
			{
				return this._Delegate.Entity;
			}
			set
			{
				Delegate previousValue = this._Delegate.Entity;
				if (((previousValue != value) 
							|| (this._Delegate.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Delegate.Entity = null;
						previousValue.Addresses.Remove(this);
					}
					this._Delegate.Entity = value;
					if ((value != null))
					{
						value.Addresses.Add(this);
						this._DelegateID = value.DelegateID;
					}
					else
					{
						this._DelegateID = default(int);
					}
					this.SendPropertyChanged("Delegate");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CourseCode;
		
		private string _CourseName;
		
		private string _CourseDescription;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseCodeChanging(string value);
    partial void OnCourseCodeChanged();
    partial void OnCourseNameChanging(string value);
    partial void OnCourseNameChanged();
    partial void OnCourseDescriptionChanging(string value);
    partial void OnCourseDescriptionChanged();
    #endregion
		
		public Course()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseCode", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CourseCode
		{
			get
			{
				return this._CourseCode;
			}
			set
			{
				if ((this._CourseCode != value))
				{
					this.OnCourseCodeChanging(value);
					this.SendPropertyChanging();
					this._CourseCode = value;
					this.SendPropertyChanged("CourseCode");
					this.OnCourseCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CourseName
		{
			get
			{
				return this._CourseName;
			}
			set
			{
				if ((this._CourseName != value))
				{
					this.OnCourseNameChanging(value);
					this.SendPropertyChanging();
					this._CourseName = value;
					this.SendPropertyChanged("CourseName");
					this.OnCourseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseDescription", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string CourseDescription
		{
			get
			{
				return this._CourseDescription;
			}
			set
			{
				if ((this._CourseDescription != value))
				{
					this.OnCourseDescriptionChanging(value);
					this.SendPropertyChanging();
					this._CourseDescription = value;
					this.SendPropertyChanged("CourseDescription");
					this.OnCourseDescriptionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CourseTraining")]
	public partial class CourseTraining
	{
		
		private string _CourseCode;
		
		private int _DelegateID;
		
		private int _TrainingID;
		
		private decimal _CourseTrainingCost;
		
		private System.DateTime _RegistrationClosingDate;
		
		public CourseTraining()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseCode", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CourseCode
		{
			get
			{
				return this._CourseCode;
			}
			set
			{
				if ((this._CourseCode != value))
				{
					this._CourseCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DelegateID", DbType="Int NOT NULL")]
		public int DelegateID
		{
			get
			{
				return this._DelegateID;
			}
			set
			{
				if ((this._DelegateID != value))
				{
					this._DelegateID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingID", DbType="Int NOT NULL")]
		public int TrainingID
		{
			get
			{
				return this._TrainingID;
			}
			set
			{
				if ((this._TrainingID != value))
				{
					this._TrainingID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseTrainingCost", DbType="Decimal(18,0) NOT NULL")]
		public decimal CourseTrainingCost
		{
			get
			{
				return this._CourseTrainingCost;
			}
			set
			{
				if ((this._CourseTrainingCost != value))
				{
					this._CourseTrainingCost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationClosingDate", DbType="DateTime NOT NULL")]
		public System.DateTime RegistrationClosingDate
		{
			get
			{
				return this._RegistrationClosingDate;
			}
			set
			{
				if ((this._RegistrationClosingDate != value))
				{
					this._RegistrationClosingDate = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Training")]
	public partial class Training : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TrainingID;
		
		private System.DateTime _TrainingStartDate;
		
		private System.DateTime _TrainingEndDate;
		
		private string _TrainingVenue;
		
		private int _TrainingVenueTotalSeats;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTrainingIDChanging(int value);
    partial void OnTrainingIDChanged();
    partial void OnTrainingStartDateChanging(System.DateTime value);
    partial void OnTrainingStartDateChanged();
    partial void OnTrainingEndDateChanging(System.DateTime value);
    partial void OnTrainingEndDateChanged();
    partial void OnTrainingVenueChanging(string value);
    partial void OnTrainingVenueChanged();
    partial void OnTrainingVenueTotalSeatsChanging(int value);
    partial void OnTrainingVenueTotalSeatsChanged();
    #endregion
		
		public Training()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TrainingID
		{
			get
			{
				return this._TrainingID;
			}
			set
			{
				if ((this._TrainingID != value))
				{
					this.OnTrainingIDChanging(value);
					this.SendPropertyChanging();
					this._TrainingID = value;
					this.SendPropertyChanged("TrainingID");
					this.OnTrainingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingStartDate", DbType="DateTime NOT NULL")]
		public System.DateTime TrainingStartDate
		{
			get
			{
				return this._TrainingStartDate;
			}
			set
			{
				if ((this._TrainingStartDate != value))
				{
					this.OnTrainingStartDateChanging(value);
					this.SendPropertyChanging();
					this._TrainingStartDate = value;
					this.SendPropertyChanged("TrainingStartDate");
					this.OnTrainingStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingEndDate", DbType="DateTime NOT NULL")]
		public System.DateTime TrainingEndDate
		{
			get
			{
				return this._TrainingEndDate;
			}
			set
			{
				if ((this._TrainingEndDate != value))
				{
					this.OnTrainingEndDateChanging(value);
					this.SendPropertyChanging();
					this._TrainingEndDate = value;
					this.SendPropertyChanged("TrainingEndDate");
					this.OnTrainingEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingVenue", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TrainingVenue
		{
			get
			{
				return this._TrainingVenue;
			}
			set
			{
				if ((this._TrainingVenue != value))
				{
					this.OnTrainingVenueChanging(value);
					this.SendPropertyChanging();
					this._TrainingVenue = value;
					this.SendPropertyChanged("TrainingVenue");
					this.OnTrainingVenueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrainingVenueTotalSeats", DbType="Int NOT NULL")]
		public int TrainingVenueTotalSeats
		{
			get
			{
				return this._TrainingVenueTotalSeats;
			}
			set
			{
				if ((this._TrainingVenueTotalSeats != value))
				{
					this.OnTrainingVenueTotalSeatsChanging(value);
					this.SendPropertyChanging();
					this._TrainingVenueTotalSeats = value;
					this.SendPropertyChanged("TrainingVenueTotalSeats");
					this.OnTrainingVenueTotalSeatsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Delegate")]
	public partial class Delegate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DelegateID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private string _PhoneNumber;
		
		private string _DietaryRequirement;
		
		private string _CompanyName;
		
		private EntitySet<Address> _Addresses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDelegateIDChanging(int value);
    partial void OnDelegateIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnDietaryRequirementChanging(string value);
    partial void OnDietaryRequirementChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    #endregion
		
		public Delegate()
		{
			this._Addresses = new EntitySet<Address>(new Action<Address>(this.attach_Addresses), new Action<Address>(this.detach_Addresses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DelegateID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DelegateID
		{
			get
			{
				return this._DelegateID;
			}
			set
			{
				if ((this._DelegateID != value))
				{
					this.OnDelegateIDChanging(value);
					this.SendPropertyChanging();
					this._DelegateID = value;
					this.SendPropertyChanged("DelegateID");
					this.OnDelegateIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DietaryRequirement", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DietaryRequirement
		{
			get
			{
				return this._DietaryRequirement;
			}
			set
			{
				if ((this._DietaryRequirement != value))
				{
					this.OnDietaryRequirementChanging(value);
					this.SendPropertyChanging();
					this._DietaryRequirement = value;
					this.SendPropertyChanged("DietaryRequirement");
					this.OnDietaryRequirementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Delegate_Address", Storage="_Addresses", ThisKey="DelegateID", OtherKey="DelegateID")]
		public EntitySet<Address> Addresses
		{
			get
			{
				return this._Addresses;
			}
			set
			{
				this._Addresses.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.Delegate = this;
		}
		
		private void detach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.Delegate = null;
		}
	}
}
#pragma warning restore 1591
