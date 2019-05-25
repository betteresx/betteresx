using FluentMigrator;

[Migration(4)]
public class PopulateJobGrades : Migration
{
    public override void Up()
    {
        Insert.IntoTable("job_grades").Row(new {
            id = 1,
            job_name = "unemployed",
            grade = 0,
            name = "unemployed",
            label = "Unemployed",
            salary = 200,
            skin_male = "{}",
            skin_female = "{}"
        });
    }

    public override void Down()
    {
        Delete.FromTable("job_grades").Row(new {
            job_name = "unemployed"
        });
    }
}