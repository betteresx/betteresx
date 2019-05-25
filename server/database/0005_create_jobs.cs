using FluentMigrator;

[Migration(5)]
public class CreateJobs : Migration
{
    public override void Up()
    {
        Create.Table("jobs")
            .WithColumn("name").AsString(50).NotNullable().PrimaryKey()
            .WithColumn("label").AsString(50).Nullable();
    }

    public override void Down()
    {
        Delete.Table("jobs");
    }
}