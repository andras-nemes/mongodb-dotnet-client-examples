using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbDotNet.Infrastructure;
using MongoDbDotNet.Repository;
using MongoDbDotNet.Repository.Aggregation;
using MongoDbDotNet.Repository.CRUD;
using MongoDbDotNet.Repository.Indexes;
using System;
using System.Collections.Generic;

namespace MongoDbDotNet
{
	class Program
	{
		static void Main(string[] args)
		{
			AggregationExamplesRunner runner = new AggregationExamplesRunner();
			//runner.RunAggregationWithDedicatedMethods();
			IndexExamplesRunner indexRunner = new IndexExamplesRunner();
			indexRunner.RunDropIndexExamples();
			Console.ReadKey();
		}		
	}
}
