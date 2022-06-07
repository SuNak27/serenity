using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Serenity.MasterData.PelanggaranRow>;
using MyRow = Serenity.MasterData.PelanggaranRow;

namespace Serenity.MasterData
{
    public interface IPelanggaranListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranListHandler
    {
        public PelanggaranListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}