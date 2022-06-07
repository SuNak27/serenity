using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Serenity.MasterData.PelanggaranRow;

namespace Serenity.MasterData
{
    public interface IPelanggaranDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PelanggaranDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPelanggaranDeleteHandler
    {
        public PelanggaranDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}