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
    
    public partial class tbl_Membership
    {
        public string MembershipID { get; set; }
        public string MembershipName { get; set; }
        public decimal MembershiPrice { get; set; }
        public bool MembershipIsDeleted { get; set; }
        public bool MembershipIsActive { get; set; }
        public string MembershipPeriod { get; set; }
    }
}
