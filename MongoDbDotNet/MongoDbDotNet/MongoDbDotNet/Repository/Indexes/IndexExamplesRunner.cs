using MongoDB.Driver;
using MongoDbDotNet.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbDotNet.Repository.Indexes
{
	public class IndexExamplesRunner
	{
		public void RunViewIndexingExamples()
		{
			ModelContext modelContext = ModelContext.Create(new ConfigFileConfigurationRepository(), new AppConfigConnectionStringRepository());
			var zipCodesIndexManager = modelContext.ZipCodes.Indexes;
			var restaurantsIndexManager = modelContext.Restaurants.Indexes;

			var zipCodesIndexList = zipCodesIndexManager.List();
			var restaurantsIndexList = restaurantsIndexManager.List();
			while (restaurantsIndexList.MoveNext())
			{
				var currentIndex = restaurantsIndexList.Current;
				foreach (var doc in currentIndex)
				{
					var docNames = doc.Names;
					foreach (string name in docNames)
					{
						var value = doc.GetValue(name);
						Debug.WriteLine(string.Concat(name, ": ", value));
					}
				}
			}
		}

		public void RunIndexCreationExamples()
		{
			ModelContext modelContext = ModelContext.Create(new ConfigFileConfigurationRepository(), new AppConfigConnectionStringRepository());
			var restaurantsIndexManager = modelContext.Restaurants.Indexes;
			var restaurantIndexDefinition = Builders<RestaurantDb>.IndexKeys.Ascending(r => r.Id);
			string result = restaurantsIndexManager.CreateOne(restaurantIndexDefinition, new CreateIndexOptions() { Name = "RestaurantIdIndexAsc", Background = true });

		}

		public void RunDropIndexExamples()
		{
			ModelContext modelContext = ModelContext.Create(new ConfigFileConfigurationRepository(), new AppConfigConnectionStringRepository());
			var restaurantsIndexManager = modelContext.Restaurants.Indexes;
			restaurantsIndexManager.DropOne("nosuchindex");
		}
	}
}
