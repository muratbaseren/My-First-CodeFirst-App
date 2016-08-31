using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstCodeFirstApp.Models
{
    [Table("tblPosts")]
    public class Post
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100), Required, DisplayName("Başlık")]
        public string Title { get; set; }

        [StringLength(250), Required, DisplayName("Özet")]
        public string Summary { get; set; }

        [StringLength(50), DisplayName("Yazar")]
        public string Author { get; set; }

        [StringLength(1000), DisplayName("Metin")]
        public string Text { get; set; }

        [ScaffoldColumn(false), DisplayName("Yayın Tarihi")]
        public DateTime PublishedDate { get; set; }

        [ScaffoldColumn(false), DisplayName("Güncelleme Tarihi")]
        public DateTime? ModifiedDate { get; set; }

        [DisplayName("Taslak")]
        public bool IsDraft { get; set; }

        public int CategoryId { get; set; }

        [DisplayName("Kategorisi")]
        public virtual Category Category { get; set; }
    }
}