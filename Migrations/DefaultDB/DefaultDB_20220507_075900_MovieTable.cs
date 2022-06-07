using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Serenity.Migrations.DefaultDB
{

    [Migration(20220507_075900)]
    public class DefaultDB_20220507_075900_MovieTable : Migration
    {
        public override void Up()
        {
            Create.Table("Movie")
                .WithColumn("MovieId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(200).NotNullable()
                .WithColumn("Description").AsString(1000).Nullable()
                .WithColumn("Storyline").AsString(2000).Nullable()
                .WithColumn("Year").AsInt32().Nullable()
                .WithColumn("ReleaseDate").AsDateTime().Nullable()
                .WithColumn("Runtime").AsInt32().Nullable();
        }

        public override void Down()
        {
        }
    }
}