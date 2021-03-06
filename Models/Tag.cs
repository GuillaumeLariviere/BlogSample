using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlogSampleApi.Models
{
    [Table("tag")]
    [Index("Mot", Name = "UQ__tag__DF50CE3C8AE6A01E", IsUnique = true)]
    public partial class Tag
    {
        public Tag()
        {
            IdArticles = new HashSet<Article>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("mot")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Mot { get; set; }
        [Column("is_deleted")]
        public bool? IsDeleted { get; set; }

        [ForeignKey("IdTag")]
        [InverseProperty("IdTags")]
        public virtual ICollection<Article> IdArticles { get; set; }
    }
}
