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
    
    public partial class tb_boq_detail3
    {
        public string boq_detail3_id { get; set; }
        public string boq_detail2_id { get; set; }
        public string item_id { get; set; }
        public Nullable<decimal> item_qty { get; set; }
        public Nullable<decimal> item_unit_price { get; set; }
    
        public virtual tb_boq_detail2 tb_boq_detail2 { get; set; }
    }
}
