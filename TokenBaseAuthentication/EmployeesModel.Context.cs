﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TokenBaseAuthentication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestingDBEntities : DbContext
    {
        public TestingDBEntities()
            : base("name=TestingDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CurrencyMaster> CurrencyMasters { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<Record> Records { get; set; }
        public virtual DbSet<studentdetail> studentdetails { get; set; }
        public virtual DbSet<time_zones> time_zones { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<temp> temps { get; set; }
    }
}
