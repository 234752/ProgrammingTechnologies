﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DiamondShop")]
	public partial class LINQtoSQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvents(Events instance);
    partial void UpdateEvents(Events instance);
    partial void DeleteEvents(Events instance);
    partial void InsertDiamonds(Diamonds instance);
    partial void UpdateDiamonds(Diamonds instance);
    partial void DeleteDiamonds(Diamonds instance);
    partial void InsertCustomers(Customers instance);
    partial void UpdateCustomers(Customers instance);
    partial void DeleteCustomers(Customers instance);
		#endregion

	/*	public LINQtoSQLDataContext() :
				base(global::Data.Properties.Settings.Default.DBConnectionString, mappingSource)
		{
			OnCreated();
		}*/
		public LINQtoSQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LINQtoSQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Events> Events
		{
			get
			{
				return this.GetTable<Events>();
			}
		}
		
		public System.Data.Linq.Table<Diamonds> Diamonds
		{
			get
			{
				return this.GetTable<Diamonds>();
			}
		}
		
		public System.Data.Linq.Table<Customers> Customers
		{
			get
			{
				return this.GetTable<Customers>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Events : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _date;
		
		private int _id;
		
		private string _isdelivered;
		
		private int _catalogid;
		
		private int _customerid;
		
		private EntityRef<Diamonds> _Diamond;
		
		private EntityRef<Customers> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OndateChanging(string value);
    partial void OndateChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnisdeliveredChanging(string value);
    partial void OnisdeliveredChanged();
    partial void OncatalogidChanging(int value);
    partial void OncatalogidChanged();
    partial void OncustomeridChanging(int value);
    partial void OncustomeridChanged();
    #endregion
		
		public Events()
		{
			this._Diamond = default(EntityRef<Diamonds>);
			this._Customer = default(EntityRef<Customers>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isdelivered", DbType="VarChar(255) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string isdelivered
		{
			get
			{
				return this._isdelivered;
			}
			set
			{
				if ((this._isdelivered != value))
				{
					this.OnisdeliveredChanging(value);
					this.SendPropertyChanging();
					this._isdelivered = value;
					this.SendPropertyChanged("isdelivered");
					this.OnisdeliveredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_catalogid", DbType="Int NOT NULL")]
		public int catalogid
		{
			get
			{
				return this._catalogid;
			}
			set
			{
				if ((this._catalogid != value))
				{
					if (this._Diamond.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncatalogidChanging(value);
					this.SendPropertyChanging();
					this._catalogid = value;
					this.SendPropertyChanged("catalogid");
					this.OncatalogidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerid", DbType="Int NOT NULL")]
		public int customerid
		{
			get
			{
				return this._customerid;
			}
			set
			{
				if ((this._customerid != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncustomeridChanging(value);
					this.SendPropertyChanging();
					this._customerid = value;
					this.SendPropertyChanged("customerid");
					this.OncustomeridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Diamonds_Events", Storage="_Diamond", ThisKey="catalogid", OtherKey="id", IsForeignKey=true)]
		public Diamonds Diamonds
		{
			get
			{
				return this._Diamond.Entity;
			}
			set
			{
				Diamonds previousValue = this._Diamond.Entity;
				if (((previousValue != value) 
							|| (this._Diamond.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Diamond.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Diamond.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._catalogid = value.id;
					}
					else
					{
						this._catalogid = default(int);
					}
					this.SendPropertyChanged("Diamonds");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Events", Storage="_Customer", ThisKey="customerid", OtherKey="id", IsForeignKey=true)]
		public Customers Customers
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customers previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.Events.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.Events.Add(this);
						this._customerid = value.id;
					}
					else
					{
						this._customerid = default(int);
					}
					this.SendPropertyChanged("Customers");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Diamonds")]
	public partial class Diamonds : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _price;
		
		private string _quality;
		
		private int _id;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    partial void OnqualityChanging(string value);
    partial void OnqualityChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    #endregion
		
		public Diamonds()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(10,2) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quality", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string quality
		{
			get
			{
				return this._quality;
			}
			set
			{
				if ((this._quality != value))
				{
					this.OnqualityChanging(value);
					this.SendPropertyChanging();
					this._quality = value;
					this.SendPropertyChanged("quality");
					this.OnqualityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Diamonds_Events", Storage="_Events", ThisKey="id", OtherKey="catalogid")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Diamonds = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Diamonds = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _first_name;
		
		private string _last_name;
		
		private EntitySet<Events> _Events;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    #endregion
		
		public Customers()
		{
			this._Events = new EntitySet<Events>(new Action<Events>(this.attach_Events), new Action<Events>(this.detach_Events));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Events", Storage="_Events", ThisKey="id", OtherKey="customerid")]
		public EntitySet<Events> Events
		{
			get
			{
				return this._Events;
			}
			set
			{
				this._Events.Assign(value);
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
		
		private void attach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Customers = this;
		}
		
		private void detach_Events(Events entity)
		{
			this.SendPropertyChanging();
			entity.Customers = null;
		}
	}
}
#pragma warning restore 1591
