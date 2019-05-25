using FluentMigrator;

[Migration(7)]
public class CreateUserAccounts : Migration
{
    public override void Up()
    {
        Create.Table("user_accounts")
            .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
            .WithColumn("identifier").AsString(50).NotNullable().Indexed()
            .WithColumn("name").AsString(50).NotNullable()
            .WithColumn("money").AsDouble().NotNullable().WithDefaultValue(0.0);
    }

    public override void Down()
    {
        Delete.Table("user_accounts");
    }
}