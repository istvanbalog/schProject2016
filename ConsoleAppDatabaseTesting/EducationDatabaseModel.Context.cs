﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppDatabaseTesting
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EducationDatabaseEntities : DbContext
    {
        public EducationDatabaseEntities()
            : base("name=EducationDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamsUser> ExamsUsers { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectsUser> SubjectsUsers { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
