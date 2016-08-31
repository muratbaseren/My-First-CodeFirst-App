using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFirstCodeFirstApp.Models
{
    [Table("tblCategories")]
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(40), Required, DisplayName("Adı")]
        public string Name { get; set; }

        [StringLength(150), DisplayName("Açıklama")]
        public string Description { get; set; }

        [ScaffoldColumn(false), DisplayName("Oluşturma Tarihi")]
        public DateTime CreationDate { get; set; }


        public virtual List<Post> Posts { get; set; }
    }
}