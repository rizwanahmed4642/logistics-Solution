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
    
    public partial class tbl_Distribution_Packages_Info
    {
        public string Id { get; set; }
        public string DistributionId { get; set; }
        public string PackageId { get; set; }
    
        public virtual tbl_Distribution_Packages tbl_Distribution_Packages { get; set; }
        public virtual tbl_DistributionServices tbl_DistributionServices { get; set; }
    }
}
