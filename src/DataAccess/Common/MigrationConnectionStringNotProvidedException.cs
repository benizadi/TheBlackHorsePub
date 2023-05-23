namespace DataAccess.Common;

[Serializable]
public class MigrationConnectionStringNotProvidedException : Exception
{
    public MigrationConnectionStringNotProvidedException() : base("MigrationConnectionString is not set")
    {
            
    }
        
}