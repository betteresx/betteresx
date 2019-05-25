using FluentMigrator;

[Migration(8)]
public class CreateUserInventory : Migration
{
    public override void Up()
    {
        Create.Table("user_inventory")
            .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
            .WithColumn("identifier").AsString(50).NotNullable().Indexed()
            .WithColumn("item").AsString(50).NotNullable()
            .WithColumn("count").AsInt32().NotNullable().WithDefaultValue(0);
    }

    public override void Down()
    {
        Delete.Table("user_inventory");
    }
}