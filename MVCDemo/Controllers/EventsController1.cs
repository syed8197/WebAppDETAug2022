﻿
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EventsController : Controller
    {
        public static List<Booking> events { get; set; }

        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "ask CLIENT", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "ask PROJECT MANAGER", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "ask TRAINER", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "ask TRAINEE", EventDate = DateTime.Today, Qty = 10 });

            return View(events);

            
        }
    }
}