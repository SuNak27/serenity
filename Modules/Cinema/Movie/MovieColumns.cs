using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.Cinema.Columns
{
    [ColumnsScript("Cinema.Movie")]
    [BasedOnRow(typeof(MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieId { get; set; }
        [EditLink]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Storyline { get; set; }
        public int Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public CinemaKind Kind { get; set; }
        [Width(100), QuickFilter]
        public string GenreName { get; set; }
        [DisplayName("Runtime In Minutes"), Width(150), AlignCenter]
        public int Runtime { get; set; }
    }
}