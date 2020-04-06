using CatHotel_Monolith.Managers;
using CatHotel_Monolith.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatHotel_Monolith.Controllers
{
    public class BookingController : ControllerBase
    {
        private readonly BookingManager bookingManager;
        private readonly CustomerManager customerManager;
        private readonly CatManager catManager;
        private readonly RoomManager roomManager;
        private readonly CatContext _context;
        private readonly BookingValidator validator = new BookingValidator();

        public BookingController(CatContext context)
        {
            _context = context;
            bookingManager = new BookingManager(_context);
            customerManager = new CustomerManager(_context);
            roomManager = new RoomManager(_context);
            catManager = new CatManager(_context);

        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Booking> Index()
        {
            return bookingManager.GetAllBookings();
        }

        // POST: Booking/Create
        [HttpPost]
        [Route("Api/Booking/MakeBooking")]
        public ActionResult Create(IEnumerable<Guid> cat, Guid customer, Guid users, Guid room, DateTime startDate, DateTime endDate, string notes)
        {
            IList<Cat> cats = new List<Cat>();
            for (int i = 0; i < cat.Count(); i++)
            {
                cats.Add(catManager.Find(cat.ElementAt(i)));
            };



            Booking booking = new Booking()
            {
                Cats = cats.ToList(),
                Customer = customerManager.Find(customer),
                Room = roomManager.Find(room),
                StartDate = startDate,
                EndDate = endDate,
                Notes = notes,
                CCTV = true,
                BookingMade = DateTime.Now,
                CheckedIn = false,
                CheckedOut = false,
                Price = 5,
                UserId = "test",
                CatsAmount = cats.Count()
            };
            ValidationResult result = validator.Validate(booking);
            if (!result.IsValid)
            {
                validator.ValidateAndThrow(booking);
            }

            bookingManager.Create(booking);
            return Ok(booking);



        }
        /*// POST: Booking/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                bookingManager.Update(booking);
                return RedirectToAction("Index");
            }
            return View(booking);
        }*/

        /*// POST: Booking/Delete/5
        [HttpDelete]
        [Route("Api/Booking/Delete")]
        public ActionResult Delete(Guid id)
        {
            bookingManager.Delete(id);
            return Ok();
        }*/
    }
}
