﻿using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.MasterData.Columns
{
    [ColumnsScript("MasterData.Kegiatan")]
    [BasedOnRow(typeof(KegiatanRow), CheckNames = true)]
    public class KegiatanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string NamaKegiatan { get; set; }
    }
}