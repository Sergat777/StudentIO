//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Speciality
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Speciality()
        {
            this.AdmissionControlNumber = new HashSet<AdmissionControlNumber>();
            this.EntranceTest = new HashSet<EntranceTest>();
            this.Group = new HashSet<Group>();
            this.Statement = new HashSet<Statement>();
        }
    
        public string CodeSpeciality { get; set; }
        public string SpecialityFullName { get; set; }
        public int EducationDuration { get; set; }
        public int FormOfEducationId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdmissionControlNumber> AdmissionControlNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntranceTest> EntranceTest { get; set; }
        public virtual FormOfEducation FormOfEducation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Statement> Statement { get; set; }
    }
}
