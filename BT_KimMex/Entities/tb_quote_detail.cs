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
    
    public partial class tb_quote_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_quote_detail()
        {
            this.tb_item_quote_attachment = new HashSet<tb_item_quote_attachment>();
        }
    
        public string quote_detail_id { get; set; }
        public string quote_id { get; set; }
        public string item_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> discount { get; set; }
        public string remark { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> discount_amount { get; set; }
        public Nullable<int> ordering_number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_item_quote_attachment> tb_item_quote_attachment { get; set; }
        public virtual tb_quote tb_quote { get; set; }
    }
}
