//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessBookWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public double PriceSubTotal { get; set; }
        public int Quantity { get; set; }
        public string State { get; set; }
        public double UnitPrice { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
