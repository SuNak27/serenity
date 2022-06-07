using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.Cinema.Columns
{
    [ColumnsScript("Cinema.Moviecast")]
    [BasedOnRow(typeof(MoviecastRow), CheckNames = true)]
    public class MoviecastColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int MovieCastId { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        [EditLink]
        public string Character { get; set; }
    }
}