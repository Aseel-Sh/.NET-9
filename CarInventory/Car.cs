namespace CarInventory
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool isAvailable { get; set; }
        public string? Secret { get; set; }
    }
}
