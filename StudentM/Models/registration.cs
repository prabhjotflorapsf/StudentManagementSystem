//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public Nullable<int> Course_Id { get; set; }
        public Nullable<int> Batch_Id { get; set; }
        public Nullable<int> TelephoneNo { get; set; }
    
        public virtual batch batch { get; set; }
        public virtual course course { get; set; }
    }
}
