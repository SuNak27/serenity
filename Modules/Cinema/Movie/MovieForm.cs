using System.Text;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.Cinema.Forms
{
    [FormScript("Cinema.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public string Title { get; set; }
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }
        [MoviecastEditor, IgnoreName]
        public List<MoviecastRow> CastList { get; set; }
        public String PrimaryImage { get; set; }
        public String GalleryImages { get; set; }
        [TextAreaEditor(Rows = 8)]
        public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public CinemaKind Kind { get; set; }
        public int Runtime { get; set; }
        public List<Int32> GenreList { get; set; }
    }
}