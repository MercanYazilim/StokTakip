//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urun()
        {
            this.KatUrun = new HashSet<KatUrun>();
            this.RafUrun = new HashSet<RafUrun>();
        }
    
        public int UrunID { get; set; }
        public string Barcod { get; set; }
        public string Resim { get; set; }
        public string UrunAdi { get; set; }
        public string UrunKodu { get; set; }
        public Nullable<int> StokMiktar { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<System.DateTime> GirisTarhi { get; set; }
        public Nullable<System.DateTime> CikisTarih { get; set; }
        public Nullable<bool> Durum { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KatUrun> KatUrun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RafUrun> RafUrun { get; set; }
    }
}
