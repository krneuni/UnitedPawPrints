﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pawprint.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbpawprintsEntities : DbContext
    {
        public dbpawprintsEntities()
            : base("name=dbpawprintsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_adopciones> tbl_adopciones { get; set; }
        public virtual DbSet<tbl_animales> tbl_animales { get; set; }
        public virtual DbSet<tbl_especies> tbl_especies { get; set; }
        public virtual DbSet<tbl_login> tbl_login { get; set; }
        public virtual DbSet<tbl_poblacion> tbl_poblacion { get; set; }
        public virtual DbSet<tbl_reportes> tbl_reportes { get; set; }
        public virtual DbSet<tbl_roles> tbl_roles { get; set; }
        public virtual DbSet<tbl_tipoRep> tbl_tipoRep { get; set; }
        public virtual DbSet<tbl_usuarios> tbl_usuarios { get; set; }
        public virtual DbSet<tbl_voluntarios> tbl_voluntarios { get; set; }
    }
}
