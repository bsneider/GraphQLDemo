public class Query {
    [GraphQLMetadata ("jedis")]
    public IEnumerable<Jedi> GetJedis () {
        return StarWarsDB.GetJedis ();
    }

    [GraphQLMetadata ("hello")]
    public string GetHello () {
        return "Hello Query class";
    }

    public static IEnumerable<Jedi> GetJedis () {
        return new List<Jedi> () {
            new Jedi () { Name = "Luke", Side = "Light" },
            new Jedi () { Name = "Yoda", Side = "Light" },
            new Jedi () { Name = "Darth Vader", Side = "Dark" }
        };
    }
}