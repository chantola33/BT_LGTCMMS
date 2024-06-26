﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kim_mexEntities : DbContext
    {
        public kim_mexEntities()
            : base("name=kim_mexEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Purchase_OrderAandR> Purchase_OrderAandR { get; set; }
        public virtual DbSet<tb_attachment> tb_attachment { get; set; }
        public virtual DbSet<tb_boq_detail1> tb_boq_detail1 { get; set; }
        public virtual DbSet<tb_boq_detail2> tb_boq_detail2 { get; set; }
        public virtual DbSet<tb_boq_detail3> tb_boq_detail3 { get; set; }
        public virtual DbSet<tb_brand> tb_brand { get; set; }
        public virtual DbSet<tb_build_of_quantity> tb_build_of_quantity { get; set; }
        public virtual DbSet<tb_build_of_quantity_detail> tb_build_of_quantity_detail { get; set; }
        public virtual DbSet<tb_class> tb_class { get; set; }
        public virtual DbSet<tb_class_type> tb_class_type { get; set; }
        public virtual DbSet<tb_color> tb_color { get; set; }
        public virtual DbSet<tb_customer> tb_customer { get; set; }
        public virtual DbSet<tb_error_log> tb_error_log { get; set; }
        public virtual DbSet<tb_history_issue_qty> tb_history_issue_qty { get; set; }
        public virtual DbSet<tb_inventory_deleted> tb_inventory_deleted { get; set; }
        public virtual DbSet<tb_inventory_status> tb_inventory_status { get; set; }
        public virtual DbSet<tb_invoice> tb_invoice { get; set; }
        public virtual DbSet<tb_ir_attachment> tb_ir_attachment { get; set; }
        public virtual DbSet<tb_ir_detail1> tb_ir_detail1 { get; set; }
        public virtual DbSet<tb_ir_detail2> tb_ir_detail2 { get; set; }
        public virtual DbSet<tb_ire_attachment> tb_ire_attachment { get; set; }
        public virtual DbSet<tb_item_blocking> tb_item_blocking { get; set; }
        public virtual DbSet<tb_item_blocking_detail> tb_item_blocking_detail { get; set; }
        public virtual DbSet<tb_item_quote_attachment> tb_item_quote_attachment { get; set; }
        public virtual DbSet<tb_item_request> tb_item_request { get; set; }
        public virtual DbSet<tb_item_return> tb_item_return { get; set; }
        public virtual DbSet<tb_job_category> tb_job_category { get; set; }
        public virtual DbSet<tb_material_request_history> tb_material_request_history { get; set; }
        public virtual DbSet<tb_mr_cut_off> tb_mr_cut_off { get; set; }
        public virtual DbSet<tb_mr_cut_off_detail> tb_mr_cut_off_detail { get; set; }
        public virtual DbSet<tb_mr_related_status> tb_mr_related_status { get; set; }
        public virtual DbSet<tb_multiple_uom> tb_multiple_uom { get; set; }
        public virtual DbSet<tb_po_attachment> tb_po_attachment { get; set; }
        public virtual DbSet<tb_po_invoice> tb_po_invoice { get; set; }
        public virtual DbSet<tb_po_invoice_document> tb_po_invoice_document { get; set; }
        public virtual DbSet<tb_po_invoice_payment> tb_po_invoice_payment { get; set; }
        public virtual DbSet<tb_po_report> tb_po_report { get; set; }
        public virtual DbSet<tb_po_report_cancelled> tb_po_report_cancelled { get; set; }
        public virtual DbSet<tb_po_report_deleted> tb_po_report_deleted { get; set; }
        public virtual DbSet<tb_po_supplier> tb_po_supplier { get; set; }
        public virtual DbSet<tb_position> tb_position { get; set; }
        public virtual DbSet<tb_procress_workflow> tb_procress_workflow { get; set; }
        public virtual DbSet<tb_product> tb_product { get; set; }
        public virtual DbSet<tb_product_category> tb_product_category { get; set; }
        public virtual DbSet<tb_product_class> tb_product_class { get; set; }
        public virtual DbSet<tb_product_detail> tb_product_detail { get; set; }
        public virtual DbSet<tb_product_size> tb_product_size { get; set; }
        public virtual DbSet<tb_product_type> tb_product_type { get; set; }
        public virtual DbSet<tb_project> tb_project { get; set; }
        public virtual DbSet<tb_project_pm> tb_project_pm { get; set; }
        public virtual DbSet<tb_purchase_order> tb_purchase_order { get; set; }
        public virtual DbSet<tb_purchase_order_detail> tb_purchase_order_detail { get; set; }
        public virtual DbSet<tb_purchase_request> tb_purchase_request { get; set; }
        public virtual DbSet<tb_purchase_request_detail> tb_purchase_request_detail { get; set; }
        public virtual DbSet<tb_purchase_requisition> tb_purchase_requisition { get; set; }
        public virtual DbSet<tb_purchase_requisition_detail> tb_purchase_requisition_detail { get; set; }
        public virtual DbSet<tb_purpose> tb_purpose { get; set; }
        public virtual DbSet<tb_quote> tb_quote { get; set; }
        public virtual DbSet<tb_quote_detail> tb_quote_detail { get; set; }
        public virtual DbSet<tb_receive_item_voucher> tb_receive_item_voucher { get; set; }
        public virtual DbSet<tb_received_item_detail> tb_received_item_detail { get; set; }
        public virtual DbSet<tb_received_status> tb_received_status { get; set; }
        public virtual DbSet<tb_reject> tb_reject { get; set; }
        public virtual DbSet<tb_return_main_stock> tb_return_main_stock { get; set; }
        public virtual DbSet<tb_return_mainstock_detail> tb_return_mainstock_detail { get; set; }
        public virtual DbSet<tb_setting_od_approval> tb_setting_od_approval { get; set; }
        public virtual DbSet<tb_site> tb_site { get; set; }
        public virtual DbSet<tb_site_manager_project> tb_site_manager_project { get; set; }
        public virtual DbSet<tb_site_site_admin> tb_site_site_admin { get; set; }
        public virtual DbSet<tb_spacemen_attachment> tb_spacemen_attachment { get; set; }
        public virtual DbSet<tb_stock_adjustment> tb_stock_adjustment { get; set; }
        public virtual DbSet<tb_stock_damage> tb_stock_damage { get; set; }
        public virtual DbSet<tb_stock_issue> tb_stock_issue { get; set; }
        public virtual DbSet<tb_stock_issue_return> tb_stock_issue_return { get; set; }
        public virtual DbSet<tb_stock_keeper_warehouse> tb_stock_keeper_warehouse { get; set; }
        public virtual DbSet<tb_stock_transfer_detail> tb_stock_transfer_detail { get; set; }
        public virtual DbSet<tb_stock_transfer_voucher> tb_stock_transfer_voucher { get; set; }
        public virtual DbSet<tb_sub_group> tb_sub_group { get; set; }
        public virtual DbSet<tb_supplier> tb_supplier { get; set; }
        public virtual DbSet<tb_system_menu> tb_system_menu { get; set; }
        public virtual DbSet<tb_system_menu_action> tb_system_menu_action { get; set; }
        public virtual DbSet<tb_transfer_frommain_stock_detail> tb_transfer_frommain_stock_detail { get; set; }
        public virtual DbSet<tb_unit> tb_unit { get; set; }
        public virtual DbSet<tb_user_deleted> tb_user_deleted { get; set; }
        public virtual DbSet<tb_user_detail> tb_user_detail { get; set; }
        public virtual DbSet<tb_warehouse> tb_warehouse { get; set; }
        public virtual DbSet<tb_warehouse_qaqc> tb_warehouse_qaqc { get; set; }
        public virtual DbSet<tb_workorder_planning> tb_workorder_planning { get; set; }
        public virtual DbSet<tb_workorder_returned> tb_workorder_returned { get; set; }
        public virtual DbSet<tbSiteSiteSupervisor> tbSiteSiteSupervisors { get; set; }
        public virtual DbSet<transferformmainstock> transferformmainstocks { get; set; }
        public virtual DbSet<tb_inventory> tb_inventory { get; set; }
        public virtual DbSet<tb_inventory_detail> tb_inventory_detail { get; set; }
    }
}
