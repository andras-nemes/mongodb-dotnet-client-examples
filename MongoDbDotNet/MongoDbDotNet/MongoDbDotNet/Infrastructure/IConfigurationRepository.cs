namespace MongoDbDotNet.Infrastructure
{
	public interface IConfigurationRepository
	{
		T GetConfigurationValue<T>(string key);
		T GetConfigurationValue<T>(string key, T defaultValue);
	}
}
