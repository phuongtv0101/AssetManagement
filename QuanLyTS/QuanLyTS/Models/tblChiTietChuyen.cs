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
    
    public partial class tblChiTietChuyen
    {
        public string MaLanChuyen { get; set; }
        public string MaTaiSan { get; set; }
        public int TinhTrang { get; set; }
        public string MaKho { get; set; }
        public int SoLuong { get; set; }
        public string MaNoiSD { get; set; }
    
        public virtual tblKhoLuuTru tblKhoLuuTru { get; set; }
        public virtual tblNoiSuDung tblNoiSuDung { get; set; }
        public virtual tblQuaTrinhDiChuyen tblQuaTrinhDiChuyen { get; set; }
        public virtual tblTaiSan tblTaiSan { get; set; }
        public virtual tblTinhTrang tblTinhTrang { get; set; }
    }
}
