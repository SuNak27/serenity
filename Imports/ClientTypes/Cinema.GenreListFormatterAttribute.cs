﻿using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.Cinema
{
    public partial class GenreListFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Serenity.Cinema.GenreListFormatter";

        public GenreListFormatterAttribute()
            : base(Key)
        {
        }
    }
}
