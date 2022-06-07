using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.Cinema
{
    public partial class MoviecastEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity.Cinema.MoviecastEditor";

        public MoviecastEditorAttribute()
            : base(Key)
        {
        }
    }
}
