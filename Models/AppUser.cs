using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlogSampleApi.Models
{
    [Table("app_user")]
    [Index("IdAuteur", Name = "UQ__app_user__73D59C0D2AEA0B73", IsUnique = true)]
    [Index("Login", Name = "UQ__app_user__7838F27249625627", IsUnique = true)]
    public partial class AppUser : Model
    {
/*        [Key]
        [Column("id")]
        public int Id { get; set; }*/
        [Column("login")]
        [StringLength(255)]
        [Unicode(false)]
        public string Login { get; set; } = null!;
        [Column("password")]
        [StringLength(255)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
/*        [Column("is_deleted")]
        public bool? IsDeleted { get; set; }*/
        [Column("id_auteur")]
        public int? IdAuteur { get; set; }

        [ForeignKey("IdAuteur")]
        [InverseProperty("AppUser")]
        public virtual Auteur? IdAuteurNavigation { get; set; }
    }
}
