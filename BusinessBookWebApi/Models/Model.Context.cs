﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessBookWebApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusinessBookEntities : DbContext
    {
        public BusinessBookEntities()
            : base("name=BusinessBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Local> Local { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleDetail> SaleDetail { get; set; }
        public virtual DbSet<TokenEmployee> TokenEmployee { get; set; }
    }
}
