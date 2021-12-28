namespace QlyHocBa.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemThi")]
    public partial class DiemThi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MonHocID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long HocSinhID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string NamHocID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short HocKy { get; set; }

        public short? Diem { get; set; }

        public virtual HocSinh HocSinh { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        public virtual NamHoc NamHoc { get; set; }
    }
}
