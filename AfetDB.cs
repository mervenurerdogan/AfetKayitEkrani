//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AfetKayit1.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AfetDB
    {
        public int afet_id { get; set; }
        public string seri_no { get; set; }
        public string glide_no { get; set; }
        public Nullable<System.DateTime> baslangic_tarih { get; set; }
        public Nullable<System.DateTime> bitis_tarih { get; set; }
        public string neden { get; set; }
        public string neden_aciklama { get; set; }
        public string etkilendigi_alan { get; set; }
        public string kaynak { get; set; }
        public Nullable<int> afet_tur_id { get; set; }
        public Nullable<int> il_id { get; set; }
    
        public virtual Afet_turDB Afet_turDB { get; set; }
        public virtual iller iller { get; set; }
    }
}
