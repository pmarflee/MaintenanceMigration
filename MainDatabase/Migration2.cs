using FluentMigrator;

namespace MaintenanceMigration.MainDatabase
{
    [Migration(2, "My second migration")]
    [Tags("MyTag")]
    public class Migration2 : ForwardOnlyMigration
    {
        public override void Up()
        {
        }
    }
}
