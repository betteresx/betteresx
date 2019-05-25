using FluentMigrator;


[Migration(9)]
public class CreateBetterESXAddons : Migration
{
    public override void Up()
    {
        Create.Table("addon_account")
            .WithColumn("name").AsString().NotNullable().Identity().PrimaryKey()
            .WithColumn("label").AsString().NotNullable().Indexed()
            .WithColumn("shared").AsInt32().NotNullable();

        Create.Table("addon_inventory")
            .WithColumn("name").AsString().NotNullable().Identity().PrimaryKey()
            .WithColumn("label").AsString().NotNullable().Indexed()
            .WithColumn("shared").AsInt32().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("addon_account");
        Delete.Table("addon_inventory");
    }
}