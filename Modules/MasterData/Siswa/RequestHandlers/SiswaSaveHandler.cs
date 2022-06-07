﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Serenity.MasterData.SiswaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serenity.MasterData.SiswaRow;

namespace Serenity.MasterData
{
    public interface ISiswaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SiswaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISiswaSaveHandler
    {
        public SiswaSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}