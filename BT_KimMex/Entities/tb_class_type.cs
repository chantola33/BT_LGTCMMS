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
    
    public partial class tb_class_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_class_type()
        {
            this.tb_class = new HashSet<tb_class>();
            this.tb_product_class = new HashSet<tb_product_class>();
        }
    
        public string class_type_id { get; set; }
        public string class_type_name { get; set; }
        public Nullable<bool> active { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_class> tb_class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_product_class> tb_product_class { get; set; }
    }
}