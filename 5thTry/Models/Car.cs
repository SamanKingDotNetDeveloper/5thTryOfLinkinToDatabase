using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _5thTry.Models
{
    [Table("car")]
    public class Car
    {
        [Required]
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column ("name")]
        public string CarName { get; set; }

        [Required]
        [Column("number")]
        public string CarNumber { get; set; }

        [Required]
        [Column("color")]
        public string Color { get; set; }
    }
}
