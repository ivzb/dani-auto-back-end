//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService.Data
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
    
        public int Id { get; set; }
        public int Lot { get; set; }
        public int Year { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int CategoryId { get; set; }
        public string Damage { get; set; }
        public string EngineType { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual Category Category { get; set; }
        public virtual Make Make { get; set; }
        public virtual Model Model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
    }
}
