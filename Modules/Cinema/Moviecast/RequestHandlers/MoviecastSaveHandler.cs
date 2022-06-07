using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity.Cinema.MoviecastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.Cinema.MoviecastRow;

namespace Serenity.Cinema
{
    public interface IMoviecastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastSaveHandler
    {
        public MoviecastSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}