//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arshf
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ArchiveCategory
    {
        public int ID { get; set; }
        public Nullable<int> IDUser { get; set; }
        public string UserName { get; set; }
        public string UserDep { get; set; }
        public string ArchiveTitel { get; set; }
        public string ArchiveDes { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
    
        public virtual TB_USERS TB_USERS { get; set; }
    }
}
