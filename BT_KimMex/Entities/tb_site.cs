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
    
    public partial class tb_site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_site()
        {
            this.tb_product_detail = new HashSet<tb_product_detail>();
            this.tb_project = new HashSet<tb_project>();
            this.tb_warehouse = new HashSet<tb_warehouse>();
        }
    
        public string site_id { get; set; }
        public string site_name { get; set; }
        public string site_address { get; set; }
        public string site_code { get; set; }
        public Nullable<System.DateTime> create_dated { get; set; }
        public Nullable<System.DateTime> updated_dated { get; set; }
        public Nullable<bool> status { get; set; }
        public string created_by { get; set; }
        public string updated_by { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_product_detail> tb_product_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_project> tb_project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_warehouse> tb_warehouse { get; set; }
    }
}