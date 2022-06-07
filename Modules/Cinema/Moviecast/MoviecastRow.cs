using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity.Cinema
{
    [ConnectionKey("Default"), Module("Cinema"), TableName("moviecast")]
    [DisplayName("Moviecast"), InstanceName("Moviecast")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MoviecastRow : Row<MoviecastRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Cast Id"), Identity, IdProperty]
        public int? MovieCastId
        {
            get => fields.MovieCastId[this];
            set => fields.MovieCastId[this] = value;
        }

        [DisplayName("Movie Id"), NotNull]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Person Id"), NotNull]
        public int? PersonId
        {
            get => fields.PersonId[this];
            set => fields.PersonId[this] = value;
        }

        [DisplayName("Character"), Size(50), QuickSearch, NameProperty]
        public string Character
        {
            get => fields.Character[this];
            set => fields.Character[this] = value;
        }

        public MoviecastRow()
            : base()
        {
        }

        public MoviecastRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieCastId;
            public Int32Field MovieId;
            public Int32Field PersonId;
            public StringField Character;
        }
    }
}
