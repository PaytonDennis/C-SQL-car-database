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
    
    public partial class tblCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCar()
        {
            this.tblSales = new HashSet<tblSale>();
        }
    
        public string VIN { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public int Mileage { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Nullable<decimal> ListingPrice { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSale> tblSales { get; set; }
    }
}
