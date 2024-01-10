﻿using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Command
{
    public class CreateAlbumCommand : IRequest<Result<AlbumResponse>>
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int    ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int    Rating { get; set; }

        public CreateAlbumCommand(string title, string artist, int releaseYear, string genre, int rating)
        {
            Title       = title;
            Artist      = artist;
            ReleaseYear = releaseYear;
            Genre       = genre;
            Rating      = rating;
        }
    }
}
