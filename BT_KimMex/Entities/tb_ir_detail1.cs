//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_KimMex.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ir_detail1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_ir_detail1()
        {
            this.tb_ir_detail2 = new HashSet<tb_ir_detail2>();
        }
    
        public string ir_detail1_id { get; set; }
        public string ir_id { get; set; }
        public string ir_job_category_id { get; set; }
    
        public virtual tb_job_category tb_job_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ir_detail2> tb_ir_detail2 { get; set; }
    }
}