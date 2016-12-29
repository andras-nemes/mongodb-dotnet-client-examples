namespace MongoDbDotNet.Infrastructure
{
	public interface IConnectionStringRepository
	{
		string ReadConnectionString(string connectionStringName);
	}
}
