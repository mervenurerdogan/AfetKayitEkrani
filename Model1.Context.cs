﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AfetKayit1.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Afet_kayitEntities : DbContext
    {
        public Afet_kayitEntities()
            : base("name=Afet_kayitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Afet_turDB> Afet_turDB { get; set; }
        public virtual DbSet<AfetDB> AfetDB { get; set; }
        public virtual DbSet<ilceler> ilceler { get; set; }
        public virtual DbSet<iller> iller { get; set; }
        public virtual DbSet<onayDB> onayDB { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
