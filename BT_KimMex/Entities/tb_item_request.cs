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
    
    public partial class tb_item_request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_item_request()
        {
            this.tb_mr_cut_off = new HashSet<tb_mr_cut_off>();
            this.tb_purchase_requisition = new HashSet<tb_purchase_requisition>();
            this.tb_stock_transfer_voucher = new HashSet<tb_stock_transfer_voucher>();
        }
    
        public string ir_id { get; set; }
        public string ir_no { get; set; }
        public string ir_project_id { get; set; }
        public string ir_purpose_id { get; set; }
        public string ir_status { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string checked_by { get; set; }
        public Nullable<System.DateTime> checked_date { get; set; }
        public string approved_by { get; set; }
        public Nullable<System.DateTime> approved_date { get; set; }
        public Nullable<bool> status { get; set; }
        public bool is_completed { get; set; }
        public Nullable<bool> is_mr { get; set; }
        public string po_status { get; set; }
        public string st_status { get; set; }
        public string tw_status { get; set; }
        public Nullable<bool> is_cut_off { get; set; }
        public Nullable<System.DateTime> expected_delivery_date { get; set; }
        public Nullable<bool> is_grn { get; set; }
        public Nullable<bool> is_po_completed { get; set; }
        public Nullable<bool> is_po_partial { get; set; }
    
        public virtual tb_project tb_project { get; set; }
        public virtual tb_purpose tb_purpose { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_mr_cut_off> tb_mr_cut_off { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_purchase_requisition> tb_purchase_requisition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_stock_transfer_voucher> tb_stock_transfer_voucher { get; set; }
    }
}