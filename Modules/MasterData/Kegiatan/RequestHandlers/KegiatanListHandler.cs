using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.MasterData.KegiatanRow>;
using MyRow = Serenity.MasterData.KegiatanRow;

namespace Serenity.MasterData
{
    public interface IKegiatanListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KegiatanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKegiatanListHandler
    {
        public KegiatanListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}