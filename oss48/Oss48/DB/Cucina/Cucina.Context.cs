﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oss48.DB.Cucina
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cucinaEntities : DbContext
    {
        public cucinaEntities()
            : base("name=cucinaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ingredienti> ingredienti { get; set; }
        public virtual DbSet<ricette> ricette { get; set; }
        public virtual DbSet<ricette2ingredienti> ricette2ingredienti { get; set; }
        public virtual DbSet<tipoprodotto> tipoprodotto { get; set; }
    }
}
