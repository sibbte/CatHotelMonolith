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
            Room room = new Room() 
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
                UserId = "system"
            };

            

            Customer customer = new Customer()
            {
                FirstName = "test",
                LastName = "test",
                Address1 = "the street",
                Address2 = "the area",
                Town = "the town",
                Postcode = "BL1 5GF",
                Email = "test@test.com",
                MobNumber = "07456987456",
                TeleNumber = "01478541236",
                Cats = 0,
                UserId = "system"
                
            };
            


            if (!context.Rooms.Any())
            {
                System.Console.WriteLine("Seeding Room Data...");
                context.Rooms.Add(room);
                System.Console.WriteLine("Seeding Customer Data...");
                context.Customers.Add(customer);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Room - not seeding");
            }

            if (!context.Customers.Any())
            {
                System.Console.WriteLine("Seeding Customer Data...");
                context.Customers.Add(customer);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Customers - not seeding");
            }
        }
    }
}
