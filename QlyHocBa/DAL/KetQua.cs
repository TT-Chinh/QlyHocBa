namespace QlyHocBa.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQua")]
    public partial class KetQua
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long HocSinhID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NamHocID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LopHocID { get; set; }

        [StringLength(20)]
        public string HocLuc { get; set; }

        [StringLength(20)]
        public string HanhKiem { get; set; }

        [Column(TypeName = "ntext")]
        public string NhanXet { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }

        public virtual NamHoc NamHoc { get; set; }
    }
}
