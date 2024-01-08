namespace album_list_business.DTO
{
    public class AlbumResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
}
