//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKhoLuuTru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKhoLuuTru()
        {
            this.tblChiTietChuyens = new HashSet<tblChiTietChuyen>();
            this.tblChiTietGiaoNhans = new HashSet<tblChiTietGiaoNhan>();
            this.tblChiTietPhieuMuons = new HashSet<tblChiTietPhieuMuon>();
            this.tblChiTietPhieuTras = new HashSet<tblChiTietPhieuTra>();
            this.tblKhoTaiSans = new HashSet<tblKhoTaiSan>();
        }
    
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string MaBoPhan { get; set; }
        public string GhiChu { get; set; }
    
        public virtual tblBoPhan tblBoPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietChuyen> tblChiTietChuyens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietGiaoNhan> tblChiTietGiaoNhans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuMuon> tblChiTietPhieuMuons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietPhieuTra> tblChiTietPhieuTras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKhoTaiSan> tblKhoTaiSans { get; set; }
    }
}