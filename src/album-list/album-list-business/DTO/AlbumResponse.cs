namespace album_list_business.DTO
{
    public class AlbumResponse
    {
        //Setting up a DTO object for a response is wise in case we decide there
        //are other data we wish to include in the response. For instance,
        //we may later decide to paginate all of our API's results and this
        //type of DTO would provide an easy avenue to achieve that goal
        public int    Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int    ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int    Rating { get; set; }
    }
}
