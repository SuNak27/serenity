using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity.MasterData.KegiatanRow;

namespace Serenity.MasterData
{
    public interface IKegiatanDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KegiatanDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKegiatanDeleteHandler
    {
        public KegiatanDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}