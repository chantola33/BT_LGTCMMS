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
    
    public partial class tb_system_menu
    {
        public int id { get; set; }
        public string url { get; set; }
        public string path { get; set; }
        public string name { get; set; }
        public string iconCls { get; set; }
        public Nullable<bool> keepAlive { get; set; }
        public Nullable<bool> requireAuth { get; set; }
        public Nullable<int> parentId { get; set; }
    }
}