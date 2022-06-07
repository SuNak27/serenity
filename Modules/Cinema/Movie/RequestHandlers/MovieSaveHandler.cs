using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity.Cinema.MovieRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.Cinema.MovieRow;

namespace Serenity.Cinema
{
    public interface IMovieSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieSaveHandler
    {
        public MovieSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}