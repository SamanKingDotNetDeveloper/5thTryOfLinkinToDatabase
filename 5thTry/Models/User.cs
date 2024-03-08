using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _5thTry.Models
{
    [Table("person")]
    public class User
    {
        [Required]
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("firstname")]
        public string FirstName { get; set; }

        [Required]
        [Column("lastname")]
        public string LastName { get; set; }

        [Required]
        [Length(8,20)]
        [Column("username")]
        public string UserName { get; set; }

        [Required]
        [Length(13,13)]
        [Phone]
        [Column("phone")]
        public string Phone { get; set; }

        [Required]
        [Column("carid")]
        public int CarId { get; set; }
    }
}
