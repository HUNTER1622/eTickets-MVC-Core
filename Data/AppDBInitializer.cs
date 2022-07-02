using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuider)
        {
            using (var serviceScope = applicationBuider.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Keasri",
                            ImageURL = "https://i.imgur.com/GNzMWvp.jpg",
                            Discription = "Superb movie of akshay kumar"

                        },
                        new Cinema()
                        {
                            Name="3 Idiots",
                            ImageURL="https://images.cinemaexpress.com/uploads/user/imagelibrary/2020/5/1/original/3_Idiots.PNG",
                            Discription="Fantastic Movie of AmirKhan",
                        }


                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name="Akshay Kumar",
                            ImageURL = "https://images.indianexpress.com/2021/04/akshay-kumar-1200.jpg",
                            Bio="He is an indian actor with canadian visa ",
                        },
                        new Actor()
                        {
                            Name="Amir Khan",
                            ImageURL="https://static.abplive.com/wp-content/uploads/2020/05/13042222/Aamir-Khan.jpg?impolicy=abp_images&imwidth=720",
                            Bio="He is an Indian actor but he belongs to muslim community"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name="Karan johar",
                            ImageURL="https://images.hindustantimes.com/img/2021/12/29/1600x900/Karan_Johar_1640767410158_1640767424419.jpg",
                            Bio="Nice Producer. He supports NEPOTISM"
                        },
                        new Producer()
                        {
                            Name="Farah Khan",
                            ImageURL="https://ngs-space1.sgp1.digitaloceanspaces.com/am/uploads/mediaGallery/image/1624609535373.jpg-org",
                            Bio="Nice women"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                  {
                      new Movie()
                      {
                          ImageURL="https://www.businesstoday.in/trending/box-office/story/kesari-box-office-collection-day-23-akshay-kumar-film-domestic-earning-stands-at-rs-147-crore-187895-2019-04-13",
                          Name = "Keasri",
                          Description="Wonderful patriotic movie",
                          Price = 200,
                          StartDate= DateTime.Now.AddDays(-10),
                          EndDate = DateTime.Now.AddDays(-5),
                          MovieCategory = MovieCategory.Action,
                          CinemaId = 1,
                          ProducerId= 1
                      },
                      new Movie()
                      {
                          ImageURL="https://www.cinemaexpress.com/stories/news/2020/may/01/aamir-khan-rajkumar-hiranis-3-idiots-is-the-most-watched-movie-worldwide-amidst-lockdown-18261.html",
                          Name = "3 Idiots",
                          Description="Wonderful Comedy and drama shows in this movie",
                          Price = 500,
                          StartDate= DateTime.Now,
                          EndDate = DateTime.Now.AddDays(+15),
                          MovieCategory = MovieCategory.Comedy,
                          CinemaId = 2,
                          ProducerId= 2
                      }
                  });
                    context.SaveChanges();

                }
                if (!context.Movies_Actors.Any())
                {
                    context.Movies_Actors.AddRange(new List<Movies_Actor>() {
                        new Movies_Actor()
                        {
                            MovieId=1,
                            ActorId=1
                        },
                        new Movies_Actor()
                        {
                            MovieId=1,
                            ActorId=2
                        },
                        new Movies_Actor()
                        {
                            MovieId = 2,
                            ActorId =1
                        },
                        new Movies_Actor()
                        {
                            MovieId=2,
                            ActorId = 2
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
