﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity.Cinema.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.Cinema.MovieGenresRow;

namespace Serenity.Cinema
{
    public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
    {
        public MovieGenresSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}