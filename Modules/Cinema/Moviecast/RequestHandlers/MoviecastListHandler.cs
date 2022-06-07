using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.Cinema.MoviecastRow>;
using MyRow = Serenity.Cinema.MoviecastRow;

namespace Serenity.Cinema
{
    public interface IMoviecastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MoviecastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMoviecastListHandler
    {
        public MoviecastListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}