﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppdeSaude.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppSaudeEntities2 : DbContext
    {
        public AppSaudeEntities2()
            : base("name=AppSaudeEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alimentos> alimentos { get; set; }
        public virtual DbSet<analises> analises { get; set; }
        public virtual DbSet<atividadefisica> atividadefisica { get; set; }
        public virtual DbSet<clinica> clinica { get; set; }
        public virtual DbSet<consulta> consulta { get; set; }
        public virtual DbSet<localidade> localidade { get; set; }
        public virtual DbSet<medicacao> medicacao { get; set; }
        public virtual DbSet<medico> medico { get; set; }
        public virtual DbSet<parametrosimc> parametrosimc { get; set; }
        public virtual DbSet<perguntas> perguntas { get; set; }
        public virtual DbSet<registos> registos { get; set; }
        public virtual DbSet<respostas> respostas { get; set; }
        public virtual DbSet<utilizador> utilizador { get; set; }
    }
}