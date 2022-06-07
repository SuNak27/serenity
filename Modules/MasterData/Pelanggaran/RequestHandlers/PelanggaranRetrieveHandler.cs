using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity.MasterData.PelanggaranRow>;
using MyRow = Serenity.MasterData.PelanggaranRow;

namespace Serenity.MasterData
{
    public interface IPelanggaranRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranRetrieveHandler
    {
        public PelanggaranRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}