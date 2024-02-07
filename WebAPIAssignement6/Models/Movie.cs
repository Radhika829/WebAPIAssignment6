using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIAssignement6.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string MName { get; set; }
        public string StatCast { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
