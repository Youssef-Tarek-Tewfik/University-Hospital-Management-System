//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_Hospital_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class APPOINTMENT
    {
        public APPOINTMENT()
        {
            this.ATTENDS = new HashSet<ATTEND>();
        }
    
        public int ID { get; set; }
        public string ATIME { get; set; }
        public string ADATE { get; set; }
        public short FEES { get; set; }
        public string TYPE { get; set; }
    
        public virtual ICollection<ATTEND> ATTENDS { get; set; }
    }
}