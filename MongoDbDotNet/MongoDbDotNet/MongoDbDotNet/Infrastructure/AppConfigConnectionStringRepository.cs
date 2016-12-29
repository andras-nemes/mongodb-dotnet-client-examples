using System.Configuration;
namespace MongoDbDotNet.Infrastructure
{
	public class AppConfigConnectionStringRepository : IConnectionStringRepository
	{
		public string ReadConnectionString(string connectionStringName)
		{
			return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
		}
	}
}
