using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Serenity.MasterData
{
    public partial class PelanggaranDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Serenity.MasterData.PelanggaranDetailEditor";

        public PelanggaranDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
