﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DQAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DeliveryEntities : DbContext
    {
        public DeliveryEntities()
            : base("name=DeliveryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Order_tbl> Order_tbl { get; set; }
    
        public virtual ObjectResult<sp_GetOrderData_Result> sp_GetOrderData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetOrderData_Result>("sp_GetOrderData");
        }
    }
}
