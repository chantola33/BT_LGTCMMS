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
    
    public partial class tb_purchase_request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_purchase_request()
        {
            this.tb_purchase_request_detail = new HashSet<tb_purchase_request_detail>();
        }
    
        public string pruchase_request_id { get; set; }
        public string purchase_order_id { get; set; }
        public string purchase_request_number { get; set; }
        public string purchase_request_status { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string updated_by { get; set; }
        public string checked_by { get; set; }
        public Nullable<System.DateTime> checked_date { get; set; }
        public string approved_by { get; set; }
        public Nullable<System.DateTime> approved_date { get; set; }
        public string approved_comment { get; set; }
        public string checked_comment { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<bool> is_check { get; set; }
        public string approved_signature { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_purchase_request_detail> tb_purchase_request_detail { get; set; }
    }
}
