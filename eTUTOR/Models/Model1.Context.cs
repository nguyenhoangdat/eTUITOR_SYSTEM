﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTUTOR.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eTUITOREntities : DbContext
    {
        public eTUITOREntities()
            : base("name=eTUITOREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<about> abouts { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<common> commons { get; set; }
        public virtual DbSet<contact_admin> contact_admin { get; set; }
        public virtual DbSet<contact_tutor> contact_tutor { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<history_lessons> history_lessons { get; set; }
        public virtual DbSet<parent> parents { get; set; }
        public virtual DbSet<schedule> schedules { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<submenu> submenus { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tutor> tutors { get; set; }
        public virtual DbSet<typeUser> typeUsers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<notice> notices { get; set; }
    }
}