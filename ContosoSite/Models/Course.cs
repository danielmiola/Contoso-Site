//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContosoSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Enrollment = new HashSet<Enrollment>();
        }
    
        public int CourseID { get; set; }
        public string Title { get; set; }
        public Nullable<int> Credits { get; set; }
    
        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}
