﻿using Microsoft.AspNetCore.Builder;
using MovieTicketsWebApp.Models;
using MovieTicketsWebApp.Data.Enums;

namespace MovieTicketsWebApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
             using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"
                          

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                           
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                           
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                          
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                           
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second Producer",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the third Producer",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the forth Producer",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fifth Producer",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "'Guardians of the Galaxy Vol. 3",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYrDBqMGcQicqUteZet1ljhIzNT9A_xWweFlmT2L7TAOqaIgRF_gIwaTXVFt9b2PpI9fA&usqp=CAU",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.SciFi
                        },
                        new Movie()
                        {
                            Name = "Fast X",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "https://mir-s3-cdn-cf.behance.net/project_modules/fs/74d035165134327.640207937b7b9.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Suzume",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/Suzume_no_Tojimari_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "AdiPurush",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "https://cdn.123telugu.com/content/wp-content/uploads/2022/11/Adipurush.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Ant-Man and the Wasp: Quantumania", 
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl = "https://cdn.marvel.com/content/1x/ant-man_and_the_wasp.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.SciFi
                        },
                        new Movie()
                        {
                            Name = "Ghosted",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGMzYWZlYmYtNTcyMC00ZGVjLThjN2ItMjY4MjkwN2NlMjYwXkEyXkFqcGdeQXVyOTU0NjY1MDM@._V1_.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Comedy
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        internal static object Seed()
        {
            throw new NotImplementedException();
        }
    }
}