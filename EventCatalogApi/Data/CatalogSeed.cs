using Microsoft.EntityFrameworkCore;
using EventCatalogApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventCatalogApi.Data;

namespace EventCatalogApi.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext context)
        {
            context.Database.Migrate();

            if (!context.EventTypes.Any())
            {
                context.EventTypes.AddRange(GetPreConfiguredEventTypes());
                context.SaveChanges();
            }

            if (!context.EventLocations.Any())
            {
                context.EventLocations.AddRange(GetPreConfiguredEventLocations());
                context.SaveChanges();
            }


            if (!context.EventDetails.Any())
            {
                context.EventDetails.AddRange(GetPreConfiguredEventDetails());
                context.SaveChanges();
            }


        }
        private static IEnumerable<EventType> GetPreConfiguredEventTypes()
        {
            return new List<EventType>
            {
                new EventType{Type = "PAINTINGS & PHOTOGRAPHY"},
                new EventType{Type = "HOLIDAY"},
                new EventType{Type = "YOGA & RUNNING"},
                new EventType{Type = "FOOD CARNIVALS & DINNER GALA "},
                new EventType{Type = "STAGE PERFORMANCES"},
                new EventType{Type = "WEDDINGS & BIRGTHDAYS"},
            };

        }
        private static IEnumerable<EventLocation> GetPreConfiguredEventLocations()
        {
            return new List<EventLocation>
            {
                new EventLocation {Location = "Bellevue"},
                new EventLocation {Location = "Redmond"},
                new EventLocation {Location = "Renton"},
                new EventLocation {Location = "Seattle"},
                new EventLocation {Location = "Sammamish"},
                new EventLocation {Location = "LynnWood"},
                new EventLocation {Location = "Kirkland"},
                new EventLocation {Location = "Woodinville"},
                new EventLocation {Location = "Anacortes"},
                new EventLocation {Location = "Everett"},
            };

        }
        private static IEnumerable<EventDetails> GetPreConfiguredEventDetails()
        {
            return new List<EventDetails>()
            {
                new EventDetails { EventTypeId=5, EventLocationId=2, Description = "Dance show ", Name = "Dance Show", Price = 19, Venue="Redmond High School,17272 Northeast 104th Street,Redmond, WA 98052", Occupancy=200, Age="Above 8", Date="May 9, 5PM",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/16" },
                new EventDetails { EventTypeId=6, EventLocationId=7, Description = "Join us for a wonderful evening  with Jennifer!", Name = "Birthday Bash", Price= 00, Age="Above 15", Date="May 12, 7PM", Occupancy=250, Venue="Stage 7 Pianos,12037 124th Avenue Northeast,Kirkland, WA 98034", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new EventDetails { EventTypeId=4, EventLocationId=4, Description = "Come join us for a friendly night of cultural immersion! Dinner and entertainment are provided", Name = "Food carnival", Price = 25, Age = "Above 6", Date= "May 4, 7PM", Occupancy=150, Venue="Seattle Asian Medicine and Martial Arts,12025 Lake City Way NE, STE B,Seattle, WA 98125 ",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new EventDetails { EventTypeId=6, EventLocationId=3, Description = "Enjoy the Evening and bless the couple.It's a Private Party!", Name = "Reception Party", Price = 00, Age="Above 10", Date="May 9, 7PM", Occupancy=125, Venue="High Dive Renton, Renton, WA",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new EventDetails { EventTypeId=1, EventLocationId=1, Description = "Giving & Receiving Feedback Skills for Supervisors", Name = "Photography Classes", Price = 80, Age="Above 15", Occupancy=100, Date="May 25, 4PM", Venue="Bellevue College, Bellevue", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/20" },
                new EventDetails { EventTypeId=4, EventLocationId=5, Description = "Food and Drinks !", Name = "Food Culture Night", Price = 50, Age="Above 16", Occupancy=150, Date="May 18, 7PM", Venue="801 228th Ave SE,. Sammamish, WA 98075",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new EventDetails { EventTypeId=5, EventLocationId=4, Description = "Dance Show", Name = "Ballet Dance Stage Show", Price = 10, Age="Above 18", Occupancy=100, Date="May 18, 4PM", Venue="U WASHINGTON College Students,TBD,Seattle, WA", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/17"  },
                new EventDetails { EventTypeId=6, EventLocationId=4, Description = "Party", Name = "Wedding", Price = 00, Age="Above 18", Occupancy=125, Date="May 30, 4PM", Venue="The 2100 Building,2100 24th Avenue South,Seattle, WA 98144", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new EventDetails { EventTypeId=1, EventLocationId=4, Description = "Art of Painting while enjoying the majestic beauty of colors", Name = "Painting Exhibition", Price = 25, Age="Above 15", Occupancy=100, Date="June 1, 5PM", Venue="Hyatt Regency Seattle | 3rd Floor - Columbia Ballroom,808 Howell Street,Seattle, WA 98101", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new EventDetails { EventTypeId=4, EventLocationId=6, Description = "Festival @ The Funhouse", Name = "Diwali event at The Funhouse", Price = 30, Age="Above 21", Occupancy=100, Date="June 3, 7PM", Venue="Funhouse,109 Eastlake Ave E,LynnWood" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new EventDetails { EventTypeId=3, EventLocationId=7, Description = "Lift your inner spirit and peace with yoga  ", Name = "Yoga", Price = 25, Age="Above 18", Occupancy=75, Date="May 7, 7PM", Venue="Stage 7 Pianos,12037 124th Avenue Northeast,Kirkland, WA 98034" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/19" },
                new EventDetails { EventTypeId=3, EventLocationId=9, Description = "Run 2 Be Fit", Name = "5K Running Event", Price = 45, Age="Above 20", Occupancy=100, Date="May 10, 6PM", Venue="100 Commercial Ave, Anacortes, WA 98221" ,PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/18" },
                new EventDetails { EventTypeId=2, EventLocationId=8, Description = "Festival of colors.", Name = "Holi", Price = 20, Age="Above 10", Occupancy=200, Date="May 16, 7AM", Venue="Woodinville, WA",PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new EventDetails { EventTypeId=6, EventLocationId=10, Description = "It's a Private Party", Name = "Wedding Event ", Price = 30, Age="Above 8", Occupancy=35, Date="May 3, 8AM", Venue="Verlocal,Redmond, WA 98052, United States, 16421 Cleveland St Ste B,Everett, WA 98052", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new EventDetails { EventTypeId=5, EventLocationId=1, Description ="Come celebrate local singer-songwriter!", Name = "Singing Performance Event ", Price = 99, Age="Above 10", Occupancy=150, Date="May 19, 5PM", Venue="Bellevue College,3000 Landerholm Circle Southeast,Bellevue, WA 98007", PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" },


            };
        }




    }
}