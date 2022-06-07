using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Serenity.MasterData.Forms
{
    [FormScript("MasterData.Kegiatan")]
    [BasedOnRow(typeof(KegiatanRow), CheckNames = true)]
    public class KegiatanForm
    {
        public string NamaKegiatan { get; set; }
    }
}