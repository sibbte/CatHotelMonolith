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
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 1,
                UserId = "system"
            };
            Room room1 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 2,
                UserId = "system"
            };
            Room room2 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 3,
                UserId = "system"
            };
            Room room3 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 4,
                UserId = "system"
            };
            Room room4 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 5,
                UserId = "system"
            };
            Room room5 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 6,
                UserId = "system"
            };
            Room room6 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.StandardRoom,
                MaxNoOfCatsInRoom = 2,
                RoomNo = 7,
                UserId = "system"
            };
            Room room7 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.FamilyRoom,
                MaxNoOfCatsInRoom = 4,
                RoomNo = 8,
                UserId = "system"
            };
            Room room8 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.FamilyRoom,
                MaxNoOfCatsInRoom = 4,
                RoomNo = 9,
                UserId = "system"
            };
            Room room9 = new Room()
            {
                Available = false,
                Booked = false,
                BookingEnd = DateTime.Now,
                BookingStart = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                RoomType = Enum.RoomType.FamilyRoom,
                MaxNoOfCatsInRoom = 4,
                RoomNo = 10,
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
                Cats = 1,
                UserId = "system"
                
            };
            Customer customer1 = new Customer()
            {
                FirstName = "test1",
                LastName = "test1",
                Address1 = "the street",
                Address2 = "the area",
                Town = "the town",
                Postcode = "BL1 5GF",
                Email = "test1@test1.com",
                MobNumber = "07456987456",
                TeleNumber = "01478541236",
                Cats = 1,
                UserId = "system"

            };
            Customer customer2 = new Customer()
            {
                FirstName = "test2",
                LastName = "test2",
                Address1 = "the street",
                Address2 = "the area",
                Town = "the town",
                Postcode = "BL1 5GF",
                Email = "test2@test2.com",
                MobNumber = "07456987456",
                TeleNumber = "01478541236",
                Cats = 1,
                UserId = "system"

            };
            Customer customer3 = new Customer()
            {
                FirstName = "test3",
                LastName = "test3",
                Address1 = "the street",
                Address2 = "the area",
                Town = "the town",
                Postcode = "BL1 5GF",
                Email = "test3@test3.com",
                MobNumber = "07456987456",
                TeleNumber = "01478541236",
                Cats = 1,
                UserId = "system"

            };
            Customer customer4 = new Customer()
            {
                FirstName = "test4",
                LastName = "test4",
                Address1 = "the street",
                Address2 = "the area",
                Town = "the town",
                Postcode = "BL1 5GF",
                Email = "test4@test4.com",
                MobNumber = "07456987456",
                TeleNumber = "01478541236",
                Cats = 1,
                UserId = "system"

            };

            Cat cat = new Cat()
            {
                CatName = "Cat",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "1478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer
            };

            IList<Cat> catList = new List<Cat>();
            IList<Cat> catList1 = new List<Cat>();
            IList<Cat> catList2 = new List<Cat>();
            IList<Cat> catList3 = new List<Cat>();
            IList<Cat> catList4 = new List<Cat>();

            catList.Add(cat);

            Cat cat1 = new Cat()
            {
                CatName = "Cat1",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "2478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer
            };

            catList.Add(cat1);

            Cat cat2 = new Cat()
            {
                CatName = "Cat2",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "3478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer1
            };

            catList1.Add(cat2);

            Cat cat3 = new Cat()
            {
                CatName = "Cat3",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "4478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer1
            };

            catList1.Add(cat3);

            Cat cat4 = new Cat()
            {
                CatName = "Cat4",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "5478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer2
            };

            catList2.Add(cat4);

            Cat cat5 = new Cat()
            {
                CatName = "Cat5",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "6478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer2
            };

            catList2.Add(cat5);

            Cat cat6 = new Cat()
            {
                CatName = "Cat6",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "7478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer3
            };

            catList3.Add(cat6);

            Cat cat7 = new Cat()
            {
                CatName = "Cat7",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "8478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer3
            };

            catList3.Add(cat7);

            Cat cat8 = new Cat()
            {
                CatName = "Cat8",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "9478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer4
            };

            catList4.Add(cat8);

            Cat cat9 = new Cat()
            {
                CatName = "Cat8",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "9478523698",
                Vaccination = true,
                UserId = "system",
                Customer = customer4
            };

            catList4.Add(cat9);

            Booking booking = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = catList,
                CatsAmount = 2,
                CCTV = true,
                Customer = customer,
                EndDate = DateTime.Now.AddDays(15),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = room,
                UserId = "system"
                
            };

            Booking booking1 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = catList1,
                CatsAmount = 2,
                CCTV = true,
                Customer = customer1,
                EndDate = DateTime.Now.AddDays(10),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = room1,
                UserId = "system"

            };

            Booking booking2 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = catList2,
                CatsAmount = 2,
                CCTV = true,
                Customer = customer2,
                EndDate = DateTime.Now.AddDays(12),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = room2,
                UserId = "system"

            };

            Booking booking3 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = catList3,
                CatsAmount = 2,
                CCTV = true,
                Customer = customer3,
                EndDate = DateTime.Now.AddDays(16),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = room3,
                UserId = "system"

            };

            Booking booking4 = new Booking()
            {
                CheckedIn = false,
                CheckedOut = false,
                BookingMade = DateTime.Now,
                Cats = catList4,
                CatsAmount = 2,
                CCTV = true,
                Customer = customer4,
                EndDate = DateTime.Now.AddDays(19),
                StartDate = DateTime.Now,
                Notes = "no notes",
                Price = 100,
                Room = room4,
                UserId = "system"

            };

            if (!context.Rooms.Any())
            {
                System.Console.WriteLine("Seeding Room Data...");
                context.Rooms.AddRange(room,room1, room2, room3, room4, room5, room6, room7, room8, room9);


                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Room - not seeding");
            }

            if (!context.Customers.Any())
            {
                System.Console.WriteLine("Seeding Customer Data...");
                context.Customers.AddRange(customer, customer1, customer2, customer3, customer4);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Customers - not seeding");
            }

            if (!context.Cats.Any())
            {
                System.Console.WriteLine("Seeding Cat Data...");
                context.Cats.AddRange(cat,cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Cat - not seeding");
            }

            if (!context.Bookings.Any())
            {
                System.Console.WriteLine("Seeding Bookings Data...");
                context.Bookings.AddRange(booking, booking1, booking2, booking3, booking4);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Bookings - not seeding");
            }
        }
    }
}
