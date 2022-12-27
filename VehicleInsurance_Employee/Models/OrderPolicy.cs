//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VehicleInsurance_Employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class OrderPolicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderPolicy()
        {
            this.Bills = new HashSet<Bill>();
            this.Claims = new HashSet<Claim>();
        }

        [Display(Name = "Policy Number")]
        public int PolicyNumber { get; set; }

        [Display(Name = "Vehicle ID")]
        public int VehicleID { get; set; }

        [Display(Name = "Insurance Type ID")]
        public int InsuranceTypeID { get; set; }

        [Display(Name = "Order Date")]
        public System.DateTime OrderDate { get; set; }

        [Display(Name = "Policy Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime PolicyDate { get; set; }

        [Display(Name = "Policy Duration")]
        public int PolicyDuration { get; set; }

        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Insurance Price")]
        public decimal InsurancePrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Claim> Claims { get; set; }
        public virtual InsuranceType InsuranceType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
