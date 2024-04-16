//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniOBS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenci
    {
        public Ogrenci()
        {
            this.OgrenciDers = new HashSet<OgrenciDers>();
            this.OgrenciNot = new HashSet<OgrenciNot>();
        }
    
        public int OgrenciID { get; set; }
        public string OgrenciNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public byte[] Resim { get; set; }
        public Nullable<int> SinifId { get; set; }
    
        public virtual Sinif Sinif { get; set; }
        public virtual ICollection<OgrenciDers> OgrenciDers { get; set; }
        public virtual ICollection<OgrenciNot> OgrenciNot { get; set; }
    }
}
