using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.Cinema.MovieRow>;
using MyRow = Serenity.Cinema.MovieRow;

namespace Serenity.Cinema
{
    public interface IMovieListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieListHandler
    {
        public MovieListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}