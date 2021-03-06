//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Bids = new HashSet<Bid>();
            this.Images = new HashSet<Image>();
        }
    
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public int CurrencyId { get; set; }
        public int TransmissionId { get; set; }
        public int FuelId { get; set; }
        public int ColorId { get; set; }
        public string Version { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string VIN { get; set; }
        public int EstimateValue { get; set; }
        public int Odometer { get; set; }
        public int Engine { get; set; }
        public string PrimaryDamage { get; set; }
        public string SecondaryDamage { get; set; }
        public string BodyStyle { get; set; }
        public string Drive { get; set; }
        public System.DateTime AuctionOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual Category Category { get; set; }
        public virtual Color Color { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Location Location { get; set; }
        public virtual Make Make { get; set; }
        public virtual Model Model { get; set; }
        public virtual Transmission Transmission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
    }
}
