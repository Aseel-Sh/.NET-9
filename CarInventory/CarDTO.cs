namespace CarInventory
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool isAvailable { get; set; }

        public CarDTO() { }

        public CarDTO(Car car)
        {
            Id = car.Id;
            Make = car.Make;
            Model = car.Model;
            isAvailable = car.isAvailable;
        }
    }
}
