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
    
    public partial class tb_po_report_deleted
    {
        public string po_report_id { get; set; }
        public string po_report_number { get; set; }
        public string po_ref_id { get; set; }
        public string po_supplier_id { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<bool> vat_status { get; set; }
        public bool is_completed { get; set; }
        public Nullable<bool> is_lpo { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string updated_by { get; set; }
        public int id { get; set; }
    }
}
