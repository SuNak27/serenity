using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity.MasterData
{
    [ConnectionKey("MasterData"), Module("MasterData"), TableName("kegiatan")]
    [DisplayName("Kegiatan"), InstanceName("Kegiatan")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class KegiatanRow : Row<KegiatanRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nama Kegiatan"), Size(50), QuickSearch, NameProperty]
        public string NamaKegiatan
        {
            get => fields.NamaKegiatan[this];
            set => fields.NamaKegiatan[this] = value;
        }

        public KegiatanRow()
            : base()
        {
        }

        public KegiatanRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField NamaKegiatan;
        }
    }
}
