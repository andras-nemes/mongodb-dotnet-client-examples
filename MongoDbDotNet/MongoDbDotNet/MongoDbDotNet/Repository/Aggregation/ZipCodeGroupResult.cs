using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbDotNet.Repository.Aggregation
{
	public class ZipCodeGroupResult
	{
		[BsonId]
		[BsonElement(elementName: "_id")]
		public string State { get; set; }
		[BsonElement(elementName: "Population")]
		public int Population { get; set; }
	}
}
