using FluentMigrator;

namespace MaintenanceMigration.MainDatabase
{
    [Migration(1, "My first migration")]
    public class Migration1 : ForwardOnlyMigration
    {
        public override void Up()
        {
        }
    }
}
