using System;
using GraphQL;
using GraphQL.Types;

namespace App
{
    public class Query
    {
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return StarWarsDB.GetJedis();
        }
        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Hello Query class";
        }
        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return StarWarsDB.GetJedis().SingleOrDefault(j => j.Id == id);
        }

    }
    public class StarWarsDB
    {
        public static IEnumerable<Jedi> GetJedis()
        {
            return new List<Jedi>() {
            new Jedi () { Name = "Luke", Side = "Light" },
            new Jedi () { Name = "Yoda", Side = "Light" },
            new Jedi () { Name = "Darth Vader", Side = "Dark" }
        };
        }
    }
}