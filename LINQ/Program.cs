namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>()
            {
                "Doom Eternal",
                "Warframe",
                "Minecraft",
                "Hitman 3",
                "Forza Horizon 5",
                "Muck",
                "No Man's Sky",
            };
            
            var orderedGameNames = gameNames.OrderBy(gameName => gameName.Length).ToList();
            orderedGameNames.ForEach(game => Console.WriteLine(game));
        }
    }
}
