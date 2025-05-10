using Microsoft.EntityFrameworkCore;

namespace CarInventory
{
    public class CarDb : DbContext
    {
        public CarDb(DbContextOptions<CarDb> options) : base(options) { }

        //create cars table in db
        public DbSet<Car> Cars { get; set; }

    }
}
