﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentIO.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentIOEntities2 : DbContext
    {
        public StudentIOEntities2()
            : base("name=StudentIOEntities2")
        {
        }

        private static StudentIOEntities2 _context;

        public static StudentIOEntities2 GetContext()
        {
            if (_context == null)
                _context = new StudentIOEntities2();

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdmissionControlNumber> AdmissionControlNumber { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Enrollee> Enrollee { get; set; }
        public virtual DbSet<EnrolleeDocument> EnrolleeDocument { get; set; }
        public virtual DbSet<EnrolleeEntranceTest> EnrolleeEntranceTest { get; set; }
        public virtual DbSet<EntranceTest> EntranceTest { get; set; }
        public virtual DbSet<FormOfEducation> FormOfEducation { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<OrderOfAdmission> OrderOfAdmission { get; set; }
        public virtual DbSet<PersonalStudentFile> PersonalStudentFile { get; set; }
        public virtual DbSet<SelectionCampaign> SelectionCampaign { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<StartEducation> StartEducation { get; set; }
        public virtual DbSet<Statement> Statement { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubjectOfEntranceTest> SubjectOfEntranceTest { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}