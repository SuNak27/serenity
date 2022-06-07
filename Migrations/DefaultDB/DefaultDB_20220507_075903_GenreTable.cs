using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Serenity.Migrations.DefaultDB
{

    [Migration(20220507_075903)]
    public class DefaultDB_20220507_075903_GenreTable : Migration
    {
        public override void Up()
        {
            Create.Table("Genre")
                .WithColumn("GenreId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();
            Alter.Table("Movie")
                .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");
        }

        public override void Down()
        {
        }
    }
}