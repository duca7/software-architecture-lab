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

namespace SongSite
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sademo")]
	public partial class MyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSong(Song instance);
    partial void UpdateSong(Song instance);
    partial void DeleteSong(Song instance);
    #endregion
		
		public MyDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["sademoConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Song> Songs
		{
			get
			{
				return this.GetTable<Song>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Song")]
	public partial class Song : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Singer;
		
		private string _Album;
		
		private string _Genre;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSingerChanging(string value);
    partial void OnSingerChanged();
    partial void OnAlbumChanging(string value);
    partial void OnAlbumChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    #endregion
		
		public Song()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Singer", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Singer
		{
			get
			{
				return this._Singer;
			}
			set
			{
				if ((this._Singer != value))
				{
					this.OnSingerChanging(value);
					this.SendPropertyChanging();
					this._Singer = value;
					this.SendPropertyChanged("Singer");
					this.OnSingerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Album", DbType="NVarChar(50)")]
		public string Album
		{
			get
			{
				return this._Album;
			}
			set
			{
				if ((this._Album != value))
				{
					this.OnAlbumChanging(value);
					this.SendPropertyChanging();
					this._Album = value;
					this.SendPropertyChanged("Album");
					this.OnAlbumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(50)")]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
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
}
#pragma warning restore 1591
