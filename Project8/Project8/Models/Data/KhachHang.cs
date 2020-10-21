﻿namespace WebBanSach.Models.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DonDatHangs = new HashSet<DonDatHang>();
        }

        [Key]
        [Display(Name ="Mã khách hàng")]
        public int MaKH { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Không được để trống tên")]
        [Display(Name = "Tên khách hàng")]
        public string TenKH { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Email không được để trống")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(250)]
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [Display(Name = "Điện thoại")]
        [Required(ErrorMessage = "Không được để trống số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string DienThoai { get; set; }

        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(50)]
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50)]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }

        [Display(Name = "Ngày tạo")]
        [DataType(DataType.DateTime)]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Trạng thái")]
        public bool TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
