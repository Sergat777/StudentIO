﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentIO.DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentIOEntities : DbContext
    {
        public StudentIOEntities()
            : base("name=StudentIOEntities")
        {
        }

        public static StudentIOEntities student;

        public static StudentIOEntities GetContext()
        {
            if(student == null)
            {
                student = new StudentIOEntities();
            }return (student);
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
