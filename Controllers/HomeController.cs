using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModelFun.Models;

namespace ViewModelFun
{
public class HomeController : Controller
    {
            [HttpGet("")]
        public IActionResult Index()
            {
                Quote firstQuote = new Quote()
                {
                    quote = "This is amazing!"
                };
                Quote secondQuote = new Quote()
                {
                    quote = "What's up!"
                };
                Quote thirdQuote = new Quote()
                {
                    quote = "Don't get mad!"
                };
            List<Quote> quotes =  new List<Quote>()
                {
                    firstQuote, secondQuote, thirdQuote
                };
            return View(quotes);
            }       
        
            [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            Number firstNum = new Number()
            {
                Num = 1
            };
            Number secondNum = new Number()
            {
                Num = 2         
            };
            Number thirdNum = new Number()
            {
                Num = 3
            };
            Number fourthNum = new Number()
            {
                Num = 10
            };
            Number fifthNum = new Number()
            {
                Num = 43
            };
            Number sixthNum = new Number()
            {
                Num = 5
            };
            List<Number> numbers = new List<Number>()
            {
                firstNum, secondNum, thirdNum, fourthNum, fifthNum, sixthNum
            };
            return View("Numbers", numbers);
        }
        [HttpGet("Users")]
        public IActionResult Names()
        {
            Person firstPerson = new Person()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            Person secondPerson = new Person()
            {
                FirstName = "Sarah"
            };
            Person thirdPerson = new Person()
            {
                FirstName = "Jerry"
            };
            Person fourthPerson = new Person()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };
            Person fifthPerson = new Person()
            {
                FirstName = "Barbarah"
            };

            List<Person> people = new List<Person>()
            {
                firstPerson, secondPerson, thirdPerson, fourthPerson, fifthPerson
            };
            return View("Users", people);
            }
            [HttpGet("User")]
            public IActionResult Users()
            {
                User firstUser = new User()
            {
                user = "Moose Phillips"    
            };
            return View("User", firstUser);
        }
    }      
}