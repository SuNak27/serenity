using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Serenity.Cinema
{
    [ConnectionKey("Default"), Module("Cinema"), TableName("moviegenres")]
    [DisplayName("Movie Genres"), InstanceName("Movie Genres")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieGenresRow : Row<MovieGenresRow.RowFields>, IIdRow
    {
        [DisplayName("Movie Genre Id"), Identity, IdProperty]
        public int? MovieGenreId
        {
            get => fields.MovieGenreId[this];
            set => fields.MovieGenreId[this] = value;
        }

        [DisplayName("Movie Id"), NotNull]
        public int? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }

        [DisplayName("Genre Id"), NotNull]
        public int? GenreId
        {
            get => fields.GenreId[this];
            set => fields.GenreId[this] = value;
        }

        public MovieGenresRow()
            : base()
        {
        }

        public MovieGenresRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieGenreId;
            public Int32Field MovieId;
            public Int32Field GenreId;
        }
    }
}
