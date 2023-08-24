using eTickets.Models;
// Me quedé en esta parte
// https://www.youtube.com/watch?v=_6uKjv-BLNc&list=PL2Q8rFbm-4ruTcZY39MNOsEu4p76HQ5VX&index=17
namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                // Cinema
                if (!context.Cinemas.Any()) 
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            LogoUrl = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Description Cinema 1"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            LogoUrl = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Description Cinema 2"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            LogoUrl = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Description Cinema 3"
                        },
                    });
                    context.SaveChanges();
                }
                // Actors
                if (!context.Actors.Any())
                {

                }
                // Producers
                if (!context.Producers.Any())
                {

                }
                // Movies
                if (!context.Movies.Any())
                {

                }
                // Actors & Movies
                if (!context.Actor_Movies.Any())
                {

                }
            }
        }
    }
}
