using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity.MasterData.KegiatanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.MasterData.KegiatanRow;

namespace Serenity.MasterData
{
    public interface IKegiatanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KegiatanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKegiatanSaveHandler
    {
        public KegiatanSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}