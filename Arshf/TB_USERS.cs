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
    
    public partial class TB_USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_USERS()
        {
            this.TB_ArchiveCategory = new HashSet<TB_ArchiveCategory>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IDDep { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DepName { get; set; }
        public string UserRole { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
    
        public virtual TB_Dep TB_Dep { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ArchiveCategory> TB_ArchiveCategory { get; set; }
    }
}
