using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity.Cinema.MovieRow>;
using MyRow = Serenity.Cinema.MovieRow;

namespace Serenity.Cinema
{
    public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
    {
        public MovieRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}