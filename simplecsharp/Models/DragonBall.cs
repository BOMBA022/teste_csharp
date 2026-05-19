namespace simplecsharp.Models

{
    public class DragonBall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class dragonballApiResponse
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Image image { get; set; }
    }

    public class Names
    {
        public string name { get; set; }
    }

    public class Image
    {
        public string png { get; set; }
    }
}