using FluentMigrator;

[Migration(2)]
public class CreateItems : Migration
{
    public override void Up()
    {
        Create.Table("items")
            .WithColumn("name").AsString(50).PrimaryKey().NotNullable()
            .WithColumn("label").AsString(50).NotNullable()
            .WithColumn("limit").AsInt32().NotNullable().WithDefaultValue(-1)
            .WithColumn("rare").AsInt32().NotNullable().WithDefaultValue(0)
            .WithColumn("can_remove").AsInt32().NotNullable().WithDefaultValue(1);
    }

    public override void Down()
    {
        Delete.Table("items");
    }
}