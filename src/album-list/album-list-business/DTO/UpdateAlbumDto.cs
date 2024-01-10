using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace album_list_business.DTO
{
    public class UpdateAlbumDto
    {
        //We aren't doing it in this project, but setting default values in our DTOs
        //can be convenient if we have endpoint considerations (like using Automapper)
        //or, if we're establishing another barrier or separation of concerns between
        //external interfaces and internal logic. It could also provide flexibility
        //with more complex data types
        public int    Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int    ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int    Rating { get; set; }
    }
}
