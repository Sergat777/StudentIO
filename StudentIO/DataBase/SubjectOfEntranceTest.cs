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
    
    public partial class SubjectOfEntranceTest
    {
        public int EntranceTestId { get; set; }
        public int SubjectId { get; set; }
        public int SubjectPriority { get; set; }
    
        public virtual EntranceTest EntranceTest { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
