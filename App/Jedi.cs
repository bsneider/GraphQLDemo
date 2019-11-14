namespace App
{
    public class Jedi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Side { get; set; }
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