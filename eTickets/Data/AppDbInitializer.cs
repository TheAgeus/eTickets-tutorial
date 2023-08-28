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
                }
                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            UrlImg = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Name = "Actor 1",
                            Bio = "Lorem ipsum 1"
                        },
                        new Actor()
                        {
                            UrlImg = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Name = "Actor 2",
                            Bio = "Lorem ipsum 2"
                        },
                        new Actor()
                        {
                            UrlImg = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Name = "Actor 3",
                            Bio = "Lorem ipsum 3"
                        },
                    });
                }
                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            UrlImg = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            Name = "Actor 1",
                            Bio = "Lorem ipsum 1"
                        },
                        new Producer()
                        {
                            UrlImg = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            Name = "Actor 2",
                            Bio = "Lorem ipsum 2"
                        },
                        new Producer()
                        {
                            UrlImg = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            Name = "Actor 3",
                            Bio = "Lorem ipsum 3"
                        },
                    });
                }
                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "Desc",
                            Price = 23.50,
                            ImgUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 16,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                    });
                }
                if (!context.Actor_Movies.Any()) 
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 16,
                            MovieId = 6
                        },
                    });
                }
                // Actors & Movies
                context.SaveChanges();
            }
        }
    }
}
