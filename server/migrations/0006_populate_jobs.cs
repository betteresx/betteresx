using FluentMigrator;

[Migration(6)]
public class PopulateJobs : Migration
{
    public override void Up()
    {
        Insert.IntoTable("jobs").Row(new {
            name = "unemployed",
            label = "Unemployed",
        });
    }

    public override void Down()
    {
        Delete.FromTable("jobs").Row(new {
            name = "unemployed"
        });
    }
}