using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Models
{

    [Table("Movies")]
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category? Category { get; set; }

    }
}
