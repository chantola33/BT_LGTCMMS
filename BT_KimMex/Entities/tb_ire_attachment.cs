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
    
    public partial class tb_ire_attachment
    {
        public string ire_attachment_id { get; set; }
        public string ire_attachment_name { get; set; }
        public string ire_attachment_extension { get; set; }
        public string ire_file_path { get; set; }
        public string ire_id { get; set; }
    
        public virtual tb_receive_item_voucher tb_receive_item_voucher { get; set; }
    }
}
