//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OcdlogisticsSolution.DomainModels.Models.Entity_Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Payments
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<long> PaymentTypeId { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
    
        public virtual tbl_Order tbl_Order { get; set; }
        public virtual tbl_PaymentsTypes tbl_PaymentsTypes { get; set; }
    }
}
