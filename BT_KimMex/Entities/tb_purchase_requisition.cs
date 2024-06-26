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
    
    public partial class tb_purchase_requisition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_purchase_requisition()
        {
            this.tb_purchase_order = new HashSet<tb_purchase_order>();
            this.tb_purchase_requisition_detail = new HashSet<tb_purchase_requisition_detail>();
            this.tb_quote = new HashSet<tb_quote>();
        }
    
        public string purchase_requisition_id { get; set; }
        public string purchase_requisition_number { get; set; }
        public string material_request_id { get; set; }
        public string purchase_requisition_status { get; set; }
        public Nullable<bool> status { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string approved_by { get; set; }
        public Nullable<System.DateTime> approved_at { get; set; }
        public string approved_comment { get; set; }
        public Nullable<bool> is_quote_complete { get; set; }
    
        public virtual tb_item_request tb_item_request { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_purchase_order> tb_purchase_order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_purchase_requisition_detail> tb_purchase_requisition_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_quote> tb_quote { get; set; }
    }
}
