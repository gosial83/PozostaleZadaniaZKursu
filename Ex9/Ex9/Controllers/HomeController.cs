using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Ex9.Entities;
using Ex9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Ex9.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly List<User> _users = new List<User>()
        {
            new User()
            {
                FirstName = "Jan",
                MiddleName = "Iwan",
                LastName = "Kowalski",
                Identification = new List<Identification>()
                {
                    new Identification() {Name = "aa", Value = "dd"}
                },
                Birthday = new DateTime(1979,12,10,10,10,10),
                Email= "a@o2.pl",
                PhoneNumber = 111222333,
                PhoneCountryCode = 48,
                Details = "xxx"
            },

            new User()
            {
                FirstName = "Anna",
                MiddleName = "Marja",
                LastName = "Wesołowska",
                Identification = new List<Identification>()
                {
                    new Identification() {Name = "aa", Value = "dd"}
                },
                Birthday = new DateTime(2000,1,10,10,10,10),
                Email= "anna.maria",
                PhoneNumber = 111222366,
                PhoneCountryCode = 48,
                Details = "xxx"
            },

            new User()
            {
                FirstName = "Jan",
                MiddleName = "Marian",
                LastName = "Mariański",
                Identification = new List<Identification>()
                {
                    new Identification() {Name = "aa", Value = "dd"}
                },
                Birthday = new DateTime(2001,2,13,10,10,10),
                Email= "",
                PhoneNumber = 111222366,
                PhoneCountryCode = 48,
                Details = "xxx"
            },

            new User()
            {
                FirstName = "Kuba",
                MiddleName = "Jakub",
                LastName = "Jakubowski",
                Identification = new List<Identification>()
                {
                    new Identification() {Name = "aa", Value = "dd"}
                },
                Birthday = new DateTime(2002,3,10,10,10,10),
                Email= "kuba@jakubowski",
                PhoneNumber = 111222366,
                PhoneCountryCode = 48,
                Details = "xxx"
            },

            new User()
            {
                FirstName = "Jan",
                MiddleName = "Tomasz",
                LastName = "Mariański",
                Identification = new List<Identification>()
                {
                    new Identification() {Name = "aa", Value = "dd"}
                },
                Birthday = new DateTime(2004,4,10,10,10,10),
                Email= "jan.tomasz@emial.pl",
                PhoneNumber = 111222366,
                PhoneCountryCode = 48,
                Details = "xxx"
            }
        };

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = _users;
            return View(model.Select(e => _mapper.Map<UserDto>(e)));
        }
    }
}
