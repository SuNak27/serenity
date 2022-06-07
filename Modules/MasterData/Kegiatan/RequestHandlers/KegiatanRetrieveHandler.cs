using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Serenity.MasterData.KegiatanRow>;
using MyRow = Serenity.MasterData.KegiatanRow;

namespace Serenity.MasterData
{
    public interface IKegiatanRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KegiatanRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKegiatanRetrieveHandler
    {
        public KegiatanRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}