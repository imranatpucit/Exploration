//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStudent
    {
        public tblStudent()
        {
            this.tblStudentStatus = new HashSet<tblStudentStatu>();
        }
    
        public int intCode { get; set; }
        public string strName { get; set; }
        public string strAddress { get; set; }
    
        public virtual ICollection<tblStudentStatu> tblStudentStatus { get; set; }
    }
}
