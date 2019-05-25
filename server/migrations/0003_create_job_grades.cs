using FluentMigrator;

[Migration(3)]
public class CreateJobGrades : Migration
{
    public override void Up()
    {
        Create.Table("job_grades")
            .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
            .WithColumn("job_name").AsString(50).Nullable().WithDefaultValue(null)
            .WithColumn("grade").AsInt32().NotNullable()
            .WithColumn("name").AsString(50).NotNullable()
            .WithColumn("label").AsString(50).NotNullable()
            .WithColumn("salary").AsInt32().NotNullable()
            .WithColumn("skin_male").AsString().NotNullable()
            .WithColumn("skin_female").AsString().NotNullable();
    }

    public override void Down()
    {
        Delete.Table("job_grades");
    }
}