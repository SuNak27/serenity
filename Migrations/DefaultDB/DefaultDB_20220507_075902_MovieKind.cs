using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Serenity.Migrations.DefaultDB
{

    [Migration(20220507_075902)]
    public class DefaultDB_20220507_075902_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie")
                .AddColumn("Kind").AsInt32().NotNullable()
                .WithDefaultValue(1);            
        }

        public override void Down()
        {
        }
    }
}