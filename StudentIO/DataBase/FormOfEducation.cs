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
    
    public partial class FormOfEducation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FormOfEducation()
        {
            this.AdmissionControlNumber = new HashSet<AdmissionControlNumber>();
            this.Speciality = new HashSet<Speciality>();
        }
    
        public int IdForm { get; set; }
        public string FormName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdmissionControlNumber> AdmissionControlNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Speciality> Speciality { get; set; }
    }
}
