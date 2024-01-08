using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace album_list_model
{
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Artist { get; set; }

        [Column(TypeName = "SMALLINT")]        
        public int ReleaseYear { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Genre { get; set; }

        [Column(TypeName = "SMALLINT")]
        public int Rating { get; set; }
    }
}
       
