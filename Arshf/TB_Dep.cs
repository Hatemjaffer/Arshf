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
    
    public partial class TB_Dep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Dep()
        {
            this.TB_USERS = new HashSet<TB_USERS>();
        }
    
        public int ID { get; set; }
        public string DepName { get; set; }
        public string DepDetails { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_USERS> TB_USERS { get; set; }
    }
}
