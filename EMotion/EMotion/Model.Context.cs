﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMotion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EMotion_DBEntities : DbContext
    {
        public EMotion_DBEntities()
            : base("name=EMotion_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarInfo_T> CarInfo_T { get; set; }
        public virtual DbSet<CarModel_T> CarModel_T { get; set; }
        public virtual DbSet<CarProducer_T> CarProducer_T { get; set; }
        public virtual DbSet<Category_T> Category_T { get; set; }
        public virtual DbSet<Item_T> Item_T { get; set; }
        public virtual DbSet<ItemInfo_T> ItemInfo_T { get; set; }
        public virtual DbSet<ItemProducer_T> ItemProducer_T { get; set; }
        public virtual DbSet<Order_T> Order_T { get; set; }
        public virtual DbSet<OrderItem_T> OrderItem_T { get; set; }
        public virtual DbSet<Price_T> Price_T { get; set; }
        public virtual DbSet<SubCategory_T> SubCategory_T { get; set; }
        public virtual DbSet<SubSubCategory_T> SubSubCategory_T { get; set; }
        public virtual DbSet<Trade_T> Trade_T { get; set; }
        public virtual DbSet<User_T> User_T { get; set; }
    }
}
