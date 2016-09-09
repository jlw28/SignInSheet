//Class for connecting to MongoDB for queries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SignInSheet
{
    class Mongo
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;

        public Mongo()
        {
            
            _client = new MongoClient("mongodb://localhost");
            _database = _client.GetDatabase("Mongo");
        }

        //Queries for titles and id for each collection
        public List<BsonDocument> get_titles()
        {
            try
            {
                var collection = _database.GetCollection<BsonDocument>("sheet");
                var filter = new BsonDocument();
                var fields = Builders<BsonDocument>.Projection.Include("id").Include("title");
                //var result = await collection.Find(filter).ToListAsync();
                var results = collection.Find(filter).Project(fields).ToList();
                return results;

            }
            catch(Exception e)
            {
                Console.WriteLine("Error in getting titles ", e);
                return null;
            }

            
        }

        //get sheet entries
        public List<BsonDocument> get_collection(String title)
        {
            try
            {
                var collection = _database.GetCollection<BsonDocument>("sheet");
                //var filter = new BsonDocument();
                var filter = Builders<BsonDocument>.Filter.Eq("title", title);
                //var fields = Builders<BsonDocument>.Projection.Equals(title);
                //var result = await collection.Find(filter).ToListAsync();
                var results = collection.Find(filter).ToList();
                return results;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error in getting titles ", e);
                return null;
            }
        }

        //save entries to database
        public async void save_entries(Entries ents)
        {
            List<string> row1 = ents.GetRow1();
            row1.ToArray();
            List<string> row2 = ents.GetRow2();
            row2.ToArray();
            List<string> row3 = ents.GetRow3();
            row3.ToArray();
            List<string> row4 = ents.GetRow4();
            row4.ToArray();
            List<string> row5 = ents.GetRow5();
            row5.ToArray();
            List<string> row6 = ents.GetRow6();
            row6.ToArray();

            var document = new BsonDocument
            {
                {"title", ents.GetTitle() },
                {"header1", ents.GetHeader1() },
                {"header2", ents.GetHeader2() },
                {"header3", ents.GetHeader3() },
                {"header4", ents.GetHeader4() },
                {"header5", ents.GetHeader5() },
                {"header6", ents.GetHeader6() },
                {"row1", new BsonArray {row1[0], row1[1], row1[2], row1[3], row1[4], row1[5] } },
                {"row2", new BsonArray {row2[0], row2[1], row2[2], row2[3], row2[4], row2[5] } },
                {"row3", new BsonArray {row3[0], row3[1], row3[2], row3[3], row3[4], row3[5] } },
                {"row4", new BsonArray {row4[0], row4[1], row4[2], row4[3], row4[4], row4[5] } },
                {"row5", new BsonArray {row5[0], row5[1], row5[2], row5[3], row5[4], row5[5] } },
                {"row6", new BsonArray {row6[0], row6[1], row6[2], row6[3], row6[4], row6[5] } }
            };

            try
            {
                var collection = _database.GetCollection<BsonDocument>("sheet");
                await collection.InsertOneAsync(document);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in saving ", e);
            }

            

        }
    }
}
