//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_P_Dennis
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSale
    {
        public int SaleID { get; set; }
        public System.DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
        public string VIN { get; set; }
        public int BuyerID { get; set; }
        public int SalespersonID { get; set; }
    
        public virtual tblBuyer tblBuyer { get; set; }
        public virtual tblCar tblCar { get; set; }
        public virtual tblSalesperson tblSalesperson { get; set; }
    }
}
