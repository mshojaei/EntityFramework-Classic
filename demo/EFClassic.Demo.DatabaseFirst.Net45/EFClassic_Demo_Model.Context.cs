﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFClassic.Demo.DatabaseFirst.Net45
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;

	public partial class EntityContext : DbContext
	{
		public EntityContext() : base(@"metadata = res://*/EFClassic_Demo_Model.csdl|res://*/EFClassic_Demo_Model.ssdl|res://*/EFClassic_Demo_Model.msl;provider=System.Data.SqlClient;provider connection string='; " + EFClassic.Demo.DatabaseFirst.Net45.Program.ConnectionString + "';")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}

		public virtual DbSet<Customer> Customers { get; set; }
	}
}