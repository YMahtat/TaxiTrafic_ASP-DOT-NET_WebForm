﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiTrafic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaxiTraficEntities : DbContext
    {
        public TaxiTraficEntities()
            : base("name=TaxiTraficEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cours> Courses { get; set; }
        public DbSet<Periodic_Courses> Periodic_Courses { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AffectedDay> AffectedDays { get; set; }
    }
}
