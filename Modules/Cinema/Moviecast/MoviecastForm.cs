using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.Cinema.Forms
{
    [FormScript("Cinema.Moviecast")]
    [BasedOnRow(typeof(MoviecastRow), CheckNames = true)]
    public class MoviecastForm
    {
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Character { get; set; }
    }
}