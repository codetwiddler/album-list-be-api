using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace album_list_model
{
    public class Album
    {
        //Setting default values in the model can ensure that the DB always receives
        //a valid value, even if our DTOs don't provide one. This also centralizes
        //control over default values, and aligns with business logic being the enforcer
        //for rules and data integrity.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR"), Required, StringLength(255)]
        public string Title { get; set; } = Constants.STR_UNKNOWN_TITLE;

        [Column(TypeName = "VARCHAR"), Required, StringLength(255)]
        public string Artist { get; set; } = Constants.STR_UNKNOWN_ARTIST;

        [Column(TypeName = "SMALLINT")]
        [YearRange(1900)]
        public int ReleaseYear { get; set; }

        [Column(TypeName = "VARCHAR"), Required, StringLength(255)]
        public string Genre { get; set; } = Constants.STR_UNSPECIFIED;

        [Column(TypeName = "SMALLINT")]
        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        public int Rating { get; set; }
    }
}
       
