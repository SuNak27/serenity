using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.MasterData.Columns
{
    [ColumnsScript("MasterData.Pelanggaran")]
    [BasedOnRow(typeof(PelanggaranRow), CheckNames = true)]
    public class PelanggaranColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, Hidden]
        public int Id { get; set; }
        [EditLink]
        public string Pelanggaran { get; set; }
        public DateTime TglPelanggaran { get; set; }
        public string Keterangan { get; set; }
    }
}