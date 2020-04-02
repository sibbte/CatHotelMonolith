using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CatHotel_Monolith.Models
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CatContext>());
            }

        }

        public static void SeedData(CatContext context)
        {
            System.Console.WriteLine("Appling Migrations...");

            context.Database.Migrate();

            if (!context.Rooms.Any())
            {
                System.Console.WriteLine("Seeding Data...");
                context.Rooms.Add(
                    new Room()
                    {
                        Available = false,
                        Booked = false,
                        BookingEnd = DateTime.Now,
                        BookingStart = DateTime.Now,
                        CheckedIn = false,
                        CheckedOut = false,
                        RoomType = Enum.RoomType.FamilyRoom,
                        MaxNoOfCatsInRoom = 4,
                        RoomNo = 1,
                        UserId = "system",
                        ID = Guid.NewGuid()
                    }
                    );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data - not seeding");
            }
        }
    }
}
