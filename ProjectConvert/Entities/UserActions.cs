using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ConverterAPI.Entities
{
    [Table("UserAction", Schema = "dbo")]
    public class UserActions
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(50)]
        public string FromUnit { get; set; }

        [Required]
        [MaxLength(50)]
        public double Initial { get; set; }

        [Required]
        [MaxLength(50)]
        public string ToUnit { get; set; }

        [Required]
        [MaxLength(50)]
        public double Value { get; set; }

        [Required]
        [MaxLength(50)]
        public DateTime DateTimeStamp { get; set; }
    }
}
