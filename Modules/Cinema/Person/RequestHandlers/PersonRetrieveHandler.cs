using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity.Cinema.PersonRow>;
using MyRow = Serenity.Cinema.PersonRow;

namespace Serenity.Cinema
{
    public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
    {
        public PersonRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}