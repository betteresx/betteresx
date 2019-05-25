using FluentMigrator;


[Migration(1)]
public class AddUsers : Migration
{
    public override void Up()
    {
        Create.Column("name")
            .OnTable("users")
            .AsString(50)
            .Nullable()
            .WithDefaultValue("");

        Create.Column("skin")
            .OnTable("users")
            .AsString()
            .Nullable();

        Create.Column("job")
            .OnTable("users")
            .AsString(50)
            .Nullable()
            .WithDefaultValue("unemployed");

        Create.Column("job_grade")
            .OnTable("users")
            .AsInt32()
            .Nullable()
            .WithDefaultValue(0);

        Create.Column("loadout")
            .OnTable("users")
            .AsString()
            .Nullable();

        Create.Column("position")
            .OnTable("users")
            .AsString(36)
            .Nullable();
    }

    public override void Down()
    {
        Delete.Column("name").FromTable("users");
        Delete.Column("skin").FromTable("users");
        Delete.Column("job").FromTable("users");
        Delete.Column("job_grade").FromTable("users");
        Delete.Column("loadout").FromTable("users");
        Delete.Column("position").FromTable("users");
    }
}