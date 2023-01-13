using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MoTick.Data.Enums;
using MoTick.Models;

namespace MoTick.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            //Create an application service called Application Services

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Create a reference to the AppDbContext file
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                //Make sure the database exists and is created
                context.Database.EnsureCreated();

                //Cinema 
                if (!context.Cinemas.Any()) //if there are no cinemas in the database. Add cinemas
                                            //Create the cinemas
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                {
                    new Cinema ()
                    {
                        Name = "Kada Cinemas",
                        Logo = "https://www.kadacinemas.com/wp-content/uploads/2021/05/Kada-logo-1.png",
                        Description = "Designed to international standards with perfect acoustics, " +
                        "each auditorium is equipped with state-of-the art projection and Dolby surround sound."
                    },
                    new Cinema ()
                    {
                        Name = "Silverbird Cinemas",
                        Logo = "https://silverbirdcinemas.com/wp-content/uploads/2018/04/stv-cinemas-logo-small.png",
                        Description = "Silverbird Cinemas is a dynamic cinema organization with a vision to become the leading Media and Entertainment company in Africa."
                    },
                    new Cinema ()
                    {
                        Name = "Filmhouse",
                        Logo = "https://www.filmhouseng.com/static/images/FHC%20LOGO%20PLUS%20VERTICAL%20(1).png",
                        Description = "Filmhouse Cinemas is a dynamic film exhibition company with a style that incorporates multifarious features, " +
                        "including state-of-the-art cinema technologies and luxurious dine-in cinema services; administered by a professional operations management."
                    },
                    new Cinema ()
                    {
                        Name = "Genesis Cinemas",
                        Logo = "https://genesiscinemas.com/wp-content/uploads/2022/04/LOGO.png",
                        Description = "Genesis Cinemas is the leading cinema chain of West Africa with 12 locations, 47 screens and over 4,700 seats in opeartion across Nigeria."
                    },
                     new Cinema ()
                    {
                        Name = "Ebonylife Cinemas",
                        Logo = "https://ebonylifecinemas.com/_next/image?url=%2Fimages%2FlogoBig.png&w=1920&q=100",
                        Description = "EbonyLife Place is the premium location in Lagos for elegant restaurants, luxury cinema, and spaces for the most intimate and exclusive events."
                    }

                });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                {
                    new Actor ()
                    {
                        FullName = "Mercy Aigbe",
                        Biography = "Mercy Aigbe (born 1 January 1978) is a Nigerian actress, director, fashionista and businesswoman. She is best known for her Yoruba indigenous movies.",
                        ProfilePictureURL = "https://cdn.vanguardngr.com/wp-content/uploads/2018/01/Mercy-Aigbe.jpg?width=412&auto_optimize=medium"
                    },

                    new Actor ()
                    {
                        FullName = "Bimbo Ademoye",
                        Biography = "Bimbo Ademoye (born 4 February 1991), is a Nigerian actress.[1] She was nominated for Best Actress in a Comedy/TV series at the Africa Magic Viewers Choice Awards in 2018, for her role in the film Backup Wife (2017).",
                        ProfilePictureURL = "https://guardian.ng/wp-content/uploads/2022/10/BIMBO--1424x802.jpg"
                    },

                    new Actor ()
                    {
                        FullName = "Viola Davis",
                        Biography = "Viola Davis (born August 11, 1965) is an American actress and producer. The recipient of various accolades, including an Academy Award, a Primetime Emmy Award, and two Tony Awards, she is the only African-American to achieve the Triple Crown of Acting.",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Viola_Davis_by_Gage_Skidmore.jpg/330px-Viola_Davis_by_Gage_Skidmore.jpg"
                    },

                    new Actor ()
                    {
                        FullName = "Kanayo O. Kanayo",
                        Biography = "Anayo Modestus Onyekwere MFR popularly known as Kanayo O. Kanayo (born 1 March 1962) is a Nigerian actor and a lawyer. In 2006, he won the African Movie Academy Award for Best Actor in a Leading Role for his performance in the movie Family Battle.",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/4/40/Kanayo.jpg"
                    },

                    new Actor ()
                    {
                        FullName = "George Clooney",
                        Biography = "George Timothy Clooney (born May 6, 1961) is an American actor and filmmaker. He is the recipient of numerous accolades, including a British Academy Film Award, four Golden Globe Awards, four Screen Actors Guild Awards, and two Academy Awards, one for his acting and the other as a producer",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/George_Clooney_2016.jpg/330px-George_Clooney_2016.jpg"
                    },


                });
                    context.SaveChanges();

                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                {
                    new Producer ()
                    {
                        FullName = "Jadesola Osiberu",
                        Biography = "Jadesola Osiberu is a Nigerian writer, director and producer and founder of Greoh Studios.",
                        ProfilePictureURL = "https://i0.wp.com/www.amxafrica.com/wp-content/uploads/2019/07/48cdf7cf36dac2ccf22a43c079d89c77.jpg?w=1080&ssl=1"
                    },

                    new Producer ()
                    {
                        FullName = "Kunle Afolayan",
                        Biography = "Kunle Afolayan (listen) (born 30 September 1975) is a Nigerian actor, film producer and film director.",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Kunle_Afolayan.jpg/330px-Kunle_Afolayan.jpg"
                    },

                    new Producer ()
                    {
                        FullName = "Maria Bello",
                        Biography = "Maria Elena Bello (born April 18, 1967) is an American actress, producer, and writer.",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3a/Maria_Bello_%2831621213980%29.jpg/330px-Maria_Bello_%2831621213980%29.jpg"
                    },

                    new Producer ()
                    {
                        FullName = "Chris Odeh",
                        Biography = "Chris Odeh is known for RattleSnake: The Ahanna Story (2020), Choke (2022) and Crazy People (2018).",
                        ProfilePictureURL = "https://chrisodeh.com/wp-content/uploads/2022/07/CHRIS-ODEHS-PROFILE-5-1.png"
                    },

                    new Producer ()
                    {
                        FullName = "Tim Bevan",
                        Biography = "Timothy John Bevan, CBE (born 20 December 1957) is a New Zealand-British film producer,[2] the co-chairman (with Eric Fellner) of the production company Working Title Films.",
                        ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Tim_Bevan_%28cropped%29.jpg/330px-Tim_Bevan_%28cropped%29.jpg"
                    },
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
                        Name = "Brotherhood",
                        Synopsis = "After years of fighting to survive on the streets of Lagos, two brothers fall on opposite sides of the law. The bonds of brotherhood are put to the ultimate test as one joins a Taskforce that hunts down the other and his gang.",
                        Price = 2500 ,
                        ImageURL = "https://www.kadacinemas.com/wp-content/uploads/2022/09/brothpost-360x618_c.jpg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(18),
                        CinemaId = 1 ,
                        ProducerId = 1,
                        MovieCategory = MovieCategory.Crime
                    },

                    new Movie()
                    {
                        Name = "Anikulapo",
                        Synopsis = "A story of death, resurrection and the greedy desires of men.",
                        Price = 3500 ,
                        ImageURL = "https://silverbirdcinemas.com/wp-content/uploads/2022/09/anipopost.jpg",
                        StartDate = DateTime.Now.AddDays(-2),
                        EndDate = DateTime.Now.AddDays(26),
                        CinemaId = 2 ,
                        ProducerId = 2,
                        MovieCategory = MovieCategory.Drama
                    },

                    new Movie()
                    {
                        Name = "The woman king",
                        Synopsis = "The Woman King is the remarkable story of the Agojie, the all-female unit of warriors who protected the African Kingdom of Dahomey in the 1800s with skills and a fierceness unlike anything the world has ever seen.",
                        Price = 4500 ,
                        ImageURL = "https://www.filmhouseng.com/_next/image?url=https%3A%2F%2Fweb.filmhouse.mycloudcinema.com%2Fmedia%2Fposters%2F55%2F432%2F15ae37b9-3517-41a7-9627-8ee1d982fe9e.jpg&w=1920&q=75",
                        StartDate = DateTime.Now.AddDays(-17),
                        EndDate = DateTime.Now.AddDays(11),
                        CinemaId = 3 ,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Drama
                    },

                    new Movie()
                    {
                        Name = "Choke",
                        Synopsis = "Choke is the story of Kosi Okoye, a sickle cell warrior with anger issues, who in a bid to dull the pain from his crisis develops an addiction to painkillers and a melancholic outlook to life.",
                        Price = 2000 ,
                        ImageURL = "https://posters-uk.s3.eu-west-2.amazonaws.com/GENPOR/1916.jpg",
                        StartDate = DateTime.Now.AddDays(-2),
                        EndDate = DateTime.Now.AddDays(26),
                        CinemaId = 4,
                        ProducerId = 4,
                        MovieCategory = MovieCategory.Drama
                    },

                    new Movie()
                    {
                        Name = "Ticket to Paradise",
                        Synopsis = "Follows a divorced couple that teams up and travels to Bali to stop their daughter from making the same mistake they think they made 25 years ago.",
                        Price = 3000 ,
                        ImageURL = "https://firebasestorage.googleapis.com/v0/b/filmx-ca4c4.appspot.com/o/9KvarmnOyYvrbeZpplvtcRb4Xlu%5B1%5D.jpg?alt=media&token=62b2cbad-58ec-4c2a-b04a-b88a7f6c023c",
                        StartDate = DateTime.Now.AddDays(-9),
                        EndDate = DateTime.Now.AddDays(21),
                        CinemaId = 5,
                        ProducerId = 5,
                        MovieCategory = MovieCategory.Comedy
                    },


                });
                    context.SaveChanges();

                }

                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie()
                    {
                        ActorId = 1,
                        MovieId = 1,
                    },

                    new Actor_Movie()
                    {
                        ActorId = 2,
                        MovieId = 2,
                    },

                    new Actor_Movie()
                    {
                        ActorId = 3,
                        MovieId = 3,
                    },

                    new Actor_Movie()
                    {
                        ActorId = 4,
                        MovieId = 4,
                    },

                    new Actor_Movie()
                    {
                        ActorId = 5,
                        MovieId = 5,
                    },




                });
                    context.SaveChanges();

                }



            }





        }
    }
}
