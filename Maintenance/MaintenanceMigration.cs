using FluentMigrator;

namespace MaintenanceMigration.Maintenance
{
    [Maintenance(MigrationStage.BeforeAll)]
    public class MaintenanceMigration : ForwardOnlyMigration
    {
        public override void Up()
        {
        }
    }
}
